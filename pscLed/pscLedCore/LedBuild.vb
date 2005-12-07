Namespace NPSCLed
	Friend Class LedBuild
		Friend Structure colStruct
			Dim red As Short
			Dim green As Short
			Dim blue As Short
		End Structure
		Dim r() As Short
		Dim g() As Short
		Dim b() As Short
		Dim mvarLedPeripherie As Short
		Dim mvarLedSocket As Short
		Dim mvarLedDiode As Short
		Dim mvarLedLedLightStart As Short
		Dim mvarLedLedLightEnd As Short
		Dim rad As Short
		Dim actCol As Integer
		Dim isDark As Boolean
		Dim myBitMap As System.Drawing.Bitmap
		Dim hasBorder As Integer
		Dim mySize As Integer
		Dim myColor As New System.Drawing.Color
		Dim mvarSocketColor As Color
		Dim mvarSocketWidth As Integer
		Dim mvarSocketPercent As Integer
		Dim mvarSocketFeature As Integer = -1
		Dim mvarLedRand As Integer
		Dim mvarLed3d As Integer = 2
		Dim mvarLightStart As Integer = 20
		Dim mvarLightWidth As Double = 0.4

		Private Function colAvg(ByRef lc(,) As colStruct) As System.Drawing.Color
			Dim x As Short
			Dim y As Short
			Dim r As Short
			Dim g As Short
			Dim b As Short
			Dim o As Short
			Dim n As Short
			Dim f As Short
			Dim z As Short
			o = 6
			n = 4
			f = 1
			r = o * lc(1, 1).red
			r = r + n * (lc(0, 1).red + lc(1, 0).red)
			r = r + f * lc(0, 0).red
			g = o * lc(1, 1).green
			g = g + n * (lc(0, 1).green + lc(1, 0).green)
			g = g + f * lc(0, 0).red
			b = o * lc(1, 1).blue
			b = b + n * (lc(0, 1).blue + lc(1, 0).blue)
			b = b + f * lc(0, 0).blue
			z = o + 2 * n + f
			colAvg = System.Drawing.Color.FromArgb(r / z, g / z, b / z)
		End Function

		Public Sub buildRad(ByVal siz As Integer)
			If mvarLedRand = 0 Then setDefaults()
			Dim tmp As Double = 0.01 * siz * mvarSocketPercent
			mvarSocketWidth = Math.Round(tmp)
			rad = siz / 2
			mvarLedPeripherie = mvarLedRand / 100 * rad - 1
			mvarLedSocket = mvarLedPeripherie - mvarLed3d * hasBorder * Math.Abs(mvarSocketFeature)
			mvarLedDiode = mvarLedSocket - mvarSocketWidth * hasBorder
			mvarLedLedLightStart = mvarLedDiode - mvarLightStart / 100 * rad
			mvarLedLedLightEnd = mvarLedLedLightStart - mvarLightWidth / 100 * rad
		End Sub

		Private Function buildBitMap() As System.Drawing.Bitmap
			Dim x As Double
			Dim y As Double
			Dim rd As Double
			Dim p As Double
			Dim c As System.Drawing.Color
			Dim savc As Integer
			Dim x0 As Short
			Dim y0 As Short
			Dim r0 As Double
			Dim g0 As Double
			Dim b0 As Double
			Dim w As Double
			Dim pi As Double
			Dim pih As Double
			Dim pia As Double
			Dim l As Short
			Dim color(,) As colStruct
			Dim lc(2, 2) As colStruct
			Dim x1 As Short
			Dim y1 As Short
			ReDim color(2 * rad + 2, 2 * rad + 2)
			pi = 4 * System.Math.Atan(1)
			pih = 2 * System.Math.Atan(1)
			pia = 0.5 * System.Math.Atan(1)
			On Error Resume Next
			myBitMap = New System.Drawing.Bitmap(2 * rad, 2 * rad)
			Dim ar As Double
			Dim br As Double
			Dim ag As Double
			Dim bg As Double
			Dim ab As Double
			Dim bb As Double
			Dim s As Double = 0.5

			br = (s * s + mvarSocketColor.R) / (s * s + s)
			ar = 255 - br
			bg = (s * s + mvarSocketColor.G) / (s * s + s)
			ag = 255 - bg
			bb = (s * s + mvarSocketColor.B) / (s * s + s)
			ab = 255 - bb
			For x = -rad + 0.5 To rad - 0.5
				For y = -rad + 0.5 To rad - 0.5
					rd = System.Math.Sqrt(x * x + y * y)
					If rd > mvarLedPeripherie Then
						r0 = myColor.R
						g0 = myColor.G
						b0 = myColor.B
					ElseIf rd > mvarLedSocket Then
						If y = 0 Then
							If x > 0 Then
								p = 0
							Else
								p = pi
							End If
						Else
							p = System.Math.Atan(x / y) + pih
						End If
						p = p - pia - pia
						If p < 0 Then
							p = -p
						End If
						p = p / pi
						If y > 0 Then
							p = 1 - p
						End If
						If mvarSocketFeature = 1 Then
							p = p ^ 0.33
							r0 = ar * p * p + br * p
							g0 = ag * p * p + bg * p
							b0 = ab * p * p + bb * p
						Else
							p = p ^ 2
							r0 = ar * (1 - p) * (1 - p) + (1 - p) * br
							g0 = ag * (1 - p) * (1 - p) + (1 - p) * bg
							b0 = ab * (1 - p) * (1 - p) + (1 - p) * bb
						End If
						If r0 > 255 Then
							r0 = 255
						End If
						If g0 > 255 Then
							g0 = 255
						End If
						If b0 > 255 Then
							b0 = 255
						End If
					ElseIf rd > mvarLedDiode Then
						r0 = mvarSocketColor.R
						g0 = mvarSocketColor.G
						b0 = mvarSocketColor.B
					Else
						If Not isDark Then
							p = rd * rd / mvarLedDiode / mvarLedDiode
							p = p ^ 1.5
							r0 = r(actCol) * (1 - p / 2)
							g0 = g(actCol) * (1 - p / 2)
							b0 = b(actCol) * (1 - p / 2)
						Else
							r0 = r(actCol) / 2
							g0 = g(actCol) / 2
							b0 = b(actCol) / 2
							If rd < mvarLedLedLightStart And rd > mvarLedLedLightEnd Then
								If y = 0 Then
									If x > 0 Then
										p = 0
									Else
										p = pi
									End If
								Else
									p = CDbl(x)
									p = System.Math.Atan(p / (y)) + pih
								End If
								p = p - pia - pia
								If p < 0 Then
									p = -p
								End If
								p = p / pi
								If y > 0 Then
									p = 1 - p
								End If
								p = p * p * System.Math.Sqrt((rd - mvarLedLedLightEnd) / (mvarLedLedLightStart - mvarLedLedLightEnd))
								If p > 0.6 Then
									r0 = 255 * p
									g0 = 255 * p
									b0 = 255 * p
								End If
							End If
						End If
					End If
					x0 = x + rad - 0.5
					y0 = -y + rad - 0.5
					color(x0, y0).red = r0
					color(x0, y0).green = g0
					color(x0, y0).blue = b0
				Next y
			Next x
			On Error GoTo 0
			For x1 = 0 To rad - 1
				For y1 = 0 To rad - 1
					lc(0, 0) = color(x1 + 1, y1 + 1)
					lc(1, 0) = color(x1, y1 + 1)
					lc(0, 1) = color(x1 + 1, y1)
					lc(1, 1) = color(x1, y1)
					c = colAvg(lc)
					myBitMap.SetPixel(x1, y1, c)
					'pict.PSet (x, y), c
				Next y1
			Next x1
			For x1 = rad To 2 * rad - 1
				For y1 = 0 To rad - 1
					lc(0, 0) = color(x1 - 1, y1 + 1)
					lc(1, 0) = color(x1, y1 + 1)
					lc(0, 1) = color(x1 - 1, y1)
					lc(1, 1) = color(x1, y1)
					c = colAvg(lc)
					myBitMap.SetPixel(x1, y1, c)
					'pict.PSet (x, y), c
				Next y1
			Next x1
			For x1 = 0 To rad - 1
				For y1 = rad To 2 * rad - 1
					lc(0, 0) = color(x1 + 1, y1 - 1)
					lc(1, 0) = color(x1, y1 - 1)
					lc(0, 1) = color(x1 + 1, y1)
					lc(1, 1) = color(x1, y1)
					c = colAvg(lc)
					myBitMap.SetPixel(x1, y1, c)
					'pict.PSet (x, y), c
				Next y1
			Next x1
			For x1 = rad To 2 * rad - 1
				For y1 = rad To 2 * rad - 1
					lc(0, 0) = color(x1 - 1, y1 - 1)
					lc(1, 0) = color(x1, y1 - 1)
					lc(0, 1) = color(x1 - 1, y1)
					lc(1, 1) = color(x1, y1)
					c = colAvg(lc)
					myBitMap.SetPixel(x1, y1, c)
					'pict.PSet (x, y), c
				Next y1
			Next x1
			Return myBitMap
		End Function

		Private Sub setDefaults()
			ReDim r(7)
			ReDim g(7)
			ReDim b(7)
			r(0) = 255 : g(0) = 0 : b(0) = 0
			r(1) = 0 : g(1) = 255 : b(1) = 0
			r(2) = 0 : g(2) = 0 : b(2) = 255
			r(3) = 255 : g(3) = 255 : b(3) = 0
			r(4) = 255 : g(4) = 0 : b(4) = 255
			r(5) = 0 : g(5) = 255 : b(5) = 255
			r(6) = 255 : g(6) = 192 : b(6) = 0
			r(7) = 255 : g(7) = 255 : b(7) = 255
			mvarLedRand = 94
			mvarLed3d = 2
			mvarSocketWidth = 0
			mvarLightStart = 20
			mvarLightWidth = 0.4
			setSizeChanges(24)
		End Sub
		Private Sub setSizeChanges(ByVal s As Integer)
			Dim d As Short
			Select Case s
				Case 128, 112
					d = 15
				Case 96, 80
					d = 20
				Case 64
					d = 25
				Case 48
					d = 30
				Case 32
					d = 50
				Case 24
					d = 50
				Case 16, 12
					d = 100
			End Select
			mvarLightWidth = d
			buildRad(s)
		End Sub
		WriteOnly Property ledColor() As Integer
			Set(ByVal Value As Integer)
				If Value > 7 Then
					actCol = Value - 8
					isDark = True
				Else
					actCol = Value
					isDark = False
				End If
				mapInvalidate()
			End Set
		End Property
		ReadOnly Property ledBMP()
			Get
				If IsNothing(myBitMap) Then buildBitMap()
				Return myBitMap
			End Get
		End Property
		WriteOnly Property ledSize() As Integer
			Set(ByVal Value As Integer)
				mySize = Value
				setSizeChanges(Value)
				mapInvalidate()
			End Set
		End Property
		WriteOnly Property border() As Integer
			Set(ByVal Value As Integer)
				hasBorder = Value
				buildRad(mySize)
				mapInvalidate()
			End Set
		End Property
		WriteOnly Property backColor() As System.Drawing.Color
			Set(ByVal Value As System.Drawing.Color)
				myColor = Value
				mapInvalidate()
			End Set
		End Property
		WriteOnly Property socketColor() As Color
			Set(ByVal Value As Color)
				mvarSocketColor = Value
				mapInvalidate()
			End Set
		End Property
		WriteOnly Property socketWidth() As Integer
			Set(ByVal Value As Integer)
				mvarSocketPercent = Value
				buildRad(mySize)
				mapInvalidate()
			End Set
		End Property
		WriteOnly Property socketFeature() As Integer
			Set(ByVal Value As Integer)
				mvarSocketFeature = Value
				buildRad(mySize)
				mapInvalidate()
			End Set
		End Property
		Public Sub New()
			myColor = System.Drawing.Color.FromArgb(212, 208, 200)
		End Sub
		Private Sub mapInvalidate()
			If Not IsNothing(myBitMap) Then
				myBitMap.Dispose()
				myBitMap = Nothing
			End If
		End Sub
	End Class
End Namespace
