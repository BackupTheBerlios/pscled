Imports System.Runtime.InteropServices
Imports System.IO
Imports System.Reflection
'<ComClass(pscLed.ClassId, pscLed.InterfaceId, pscLed.EventsId)> 
Namespace NPSCLed
	Public Class PscLed
		Inherits System.Windows.Forms.UserControl

#Region " Windows Form Designer generated code "
		'#Region "COM GUIDs"
		'	' These  GUIDs provide the COM identity for this class 
		'	' and its COM interfaces. If you change them, existing 
		'	' clients will no longer be able to access the class.
		'	Public Const ClassId As String = "FAD61295-C7AF-4761-807F-50BCD781EB77"
		'	Public Const InterfaceId As String = "B9923827-5E55-437D-B120-5577835D4003"
		'	Public Const EventsId As String = "FACB497A-F050-4283-ABC3-A00DDEF4229A"
		'#End Region

		Public Sub New()
			MyBase.New()

			'This call is required by the Windows Form Designer.
			InitializeComponent()

			'Add any initialization after the InitializeComponent() call
			initColor()
		End Sub

		'UserControl1 overrides dispose to clean up the component list.
		Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If Not (components Is Nothing) Then
					components.Dispose()
				End If
			End If
			MyBase.Dispose(disposing)
		End Sub

		'Required by the Windows Form Designer
		Private components As System.ComponentModel.IContainer

		'NOTE: The following procedure is required by the Windows Form Designer
		'It can be modified using the Windows Form Designer.  
		'Do not modify it using the code editor.
		Friend WithEvents pictLeds As System.Windows.Forms.PictureBox
		Friend WithEvents blinkTimer As System.Windows.Forms.Timer
		Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
		<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container
			Me.pictLeds = New System.Windows.Forms.PictureBox
			Me.blinkTimer = New System.Windows.Forms.Timer(Me.components)
			Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
			Me.SuspendLayout()
			'
			'pictLeds
			'
			Me.pictLeds.Location = New System.Drawing.Point(0, 0)
			Me.pictLeds.Name = "pictLeds"
			Me.pictLeds.Size = New System.Drawing.Size(128, 544)
			Me.pictLeds.TabIndex = 0
			Me.pictLeds.TabStop = False
			'
			'blinkTimer
			'
			'
			'pscLed
			'
			Me.CausesValidation = False
			Me.Controls.Add(Me.pictLeds)
			Me.Name = "pscLed"
			Me.Size = New System.Drawing.Size(24, 24)
			Me.ToolTip1.SetToolTip(Me, "xxx")
			Me.ResumeLayout(False)

		End Sub

#End Region
#Region "Structures"
		Public Enum ledBorderStyle
			None
			FixedSingle
			Fixed3D
			Socket
		End Enum
		Public Enum ledSocketWidth
			widthLarge
			widthMedium
			widthSmall
			widthMini
		End Enum
		Public Enum ledSocketFeature
			sockedDeepened
			sockedFlat
			socketRaised
		End Enum
		Public Enum ledAudio
			audioOff
			beepOn
			soundOn
		End Enum
		Public Enum mainColor
			colorRed
			colorGreen
			colorBlue
			colorYellow
			colorMagenta
			colorCyan
			colorOrange
			colorGrey
		End Enum
		Public Enum ledModus
			ledOff
			ledOn
			ledFlash
			ledBlink
		End Enum
		Public Enum ledModel
			sizeMaxi
			sizeSuper
			sizeBig
			sizeLarge
			sizeMedium
			sizeSmall
			sizeMini
		End Enum
		Private Enum allColor
			ledRed
			ledGreen
			ledBlue
			ledYellow
			ledMagenta
			ledCyan
			ledOrange
			ledGrey
			ledDarkRed
			ledDarkGreen
			ledDarkBlue
			ledDarkYellow
			ledDarkMagenta
			ledDarkCyan
			ledDarkOrange
			ledDarkGrey
		End Enum
		Public Enum blinkColor
			colorRed
			colorGreen
			colorBlue
			colorYellow
			colorMagenta
			colorCyan
			colorOrange
			colorGrey
			colorDark
		End Enum
		Public Enum blinkSpeed
			blinkVeryFast
			blinkFast
			blinkMedium
			blinkSlow
			blinkVerySlow
		End Enum
		Public Enum ledTrigger
			nextDirect
			nextDelay
		End Enum
		Public Enum ledDesignMode
			blinkOff_audioOff
			blinkOn_audioOff
			blinkOn_audioOn
		End Enum
#End Region
#Region "Constant, Event and Variable Declarations"
		Private Const SND_NOWAIT = &H2000
		Private mvarColorFirst As mainColor = mainColor.colorRed
		Private mvarColorDark As allColor = allColor.ledDarkRed
		Private mvarColorAct As allColor = allColor.ledRed
		Private mvarColorSecond As allColor = allColor.ledDarkRed
		Private mvarColorBlink As blinkColor = blinkColor.colorDark
		Private mvarModus As ledModus = ledModus.ledOn
		Private mvarBlinkInterval As blinkSpeed = blinkSpeed.blinkMedium
		Private mvarBlSpeed As Integer
		Private mvarBlinkSignal As ledAudio = ledAudio.audioOff
		Private mvarOldStatus As ledModus = ledModus.ledOn
		Private mvarNextLed As pscLed
		Private mvarNextLedName As String
		Private mvarNextLedStart As ledTrigger
		Private mvarBorder As ledBorderStyle = ledBorderStyle.Socket
		Private mvarSize As ledModel = ledModel.sizeMedium
		Private mvarLive As ledDesignMode = ledDesignMode.blinkOn_audioOff
		Private mvarSoundFile = ""
		Private mvarSoundRunning As Boolean = False
		Private mvarTooltip As String
		Private mvarIsFirst As Boolean
		Private mvarLedBld1 As New LedBuild
		Private mvarLedBld2 As New LedBuild
		Private mvarBitMap1 As Bitmap
		Private mvarBitMap2 As Bitmap
		Private mvarBitMapSize As Integer
		Private mvarSocketColor As System.Drawing.KnownColor = KnownColor.Silver
		Private mwarSocketWidth As ledSocketWidth = ledSocketWidth.widthMedium
		Private mvarSocketFeature As ledSocketFeature = ledSocketFeature.socketRaised
		Private cSound As New LedSound
		Private mvarTransparent As Boolean

		Public Event FlashNext(ByRef nextName As String, ByRef cancel As Boolean)
#End Region
#Region "Subclasses"
		Public Class LedSound

			Declare Function PlaySound Lib "winmm.dll" Alias "PlaySoundA" _
			 (ByVal lpszName As IntPtr, ByVal hModule As IntPtr, ByVal dwFlags As Integer) As Integer
			Private Const SND_ASYNC = &H1
			Private Const SND_LOOP = &H8
			Private Const SND_PURGE = &H40
			Private Const SND_NOSTOP = &H10
			Private Const SND_MEMORY As Int32 = &H4

			Private Shared m_hgData As IntPtr

			Private Shared Sub stoppPlaying()
				PlaySound(IntPtr.Zero, IntPtr.Zero, SND_PURGE)				' API-Aufruf!
				Marshal.FreeHGlobal(m_hgData)
				m_hgData = IntPtr.Zero
			End Sub

			Public Shared Sub Play(ByVal sName As String, ByVal lp As Boolean)
				Dim inMemory As Boolean
				Dim memFlag As Integer
				Dim strm As Stream
				If Not m_hgData.Equals(IntPtr.Zero) Then stoppPlaying()
				Dim syst As String
				memFlag = SND_MEMORY
				strm = [Assembly].GetEntryAssembly().GetManifestResourceStream(sName)
				If IsNothing(strm) Then
					memFlag = 0
					strm = File.Open(sName, FileMode.Open)
				End If
				Dim ln As Long = CLng(strm.Length)
				Dim bt(ln - 1) As Byte
				strm.Read(bt, 0, ln)
				strm.Close()
				m_hgData = Marshal.AllocHGlobal(ln)
				Marshal.Copy(bt, 0, m_hgData, ln)
				Dim Flags As Int32 = memFlag Or SND_ASYNC
				If lp Then Flags = Flags Or SND_LOOP
				PlaySound(m_hgData, IntPtr.Zero, Flags)				' API-Aufruf!
			End Sub


			Public Shared Sub soundOff()
				If Not m_hgData.Equals(IntPtr.Zero) Then stoppPlaying()
			End Sub

		End Class
#End Region
#Region "Overrides"
		Protected Overrides Sub OnBackColorChanged(ByVal e As System.EventArgs)
			ledBackTransparent = mvarTransparent
		End Sub
		Protected Overrides Sub OnSizeChanged(ByVal e As System.EventArgs)
			Dim borderPixel As Integer
			Select Case mvarBorder
				Case BorderStyle.None
					borderPixel = 0
				Case BorderStyle.FixedSingle
					borderPixel = 2
				Case BorderStyle.Fixed3D
					borderPixel = 4
			End Select
			Select Case mvarSize
				Case ledSize.sizeMaxi
#If Demo Then
				mvarBitMapSize = 112
#Else
					mvarBitMapSize = 128
#End If
				Case ledSize.sizeSuper
					mvarBitMapSize = 80
				Case ledSize.sizeBig
					mvarBitMapSize = 48
				Case ledSize.sizeLarge
					mvarBitMapSize = 32
				Case ledSize.sizeMedium
					mvarBitMapSize = 24
				Case ledSize.sizeSmall
					mvarBitMapSize = 16
				Case ledSize.sizeMini
					mvarBitMapSize = 12
			End Select
			Me.Height = mvarBitMapSize + borderPixel
			Me.Width = mvarBitMapSize + borderPixel
			pictLeds.Width = mvarBitMapSize + borderPixel
			pictLeds.Height = mvarBitMapSize + borderPixel
		End Sub
#End Region
#Region "Properties"
		Public Property ledBorder() As ledBorderStyle
			Get
				Return mvarBorder
			End Get
			Set(ByVal Value As ledBorderStyle)
				mvarBorder = Value
				Select Case Value
					Case ledBorderStyle.None
						pictLeds.BorderStyle = BorderStyle.None
						mvarLedBld1.border = 0
						mvarLedBld2.border = 0
					Case ledBorderStyle.FixedSingle
						pictLeds.BorderStyle = BorderStyle.FixedSingle
						mvarLedBld1.border = 0
						mvarLedBld2.border = 0
					Case ledBorderStyle.Fixed3D
						pictLeds.BorderStyle = BorderStyle.Fixed3D
						mvarLedBld1.border = 0
						mvarLedBld2.border = 0
					Case ledBorderStyle.Socket
						pictLeds.BorderStyle = BorderStyle.None
						mvarLedBld1.border = 1
						mvarLedBld2.border = 1
				End Select
				OnSizeChanged(Nothing)
				If Not IsNothing(mvarBitMap2) Then mvarBitMap2.Dispose()
				mvarBitMap2 = mvarLedBld2.ledBMP
				If Not IsNothing(mvarBitMap1) Then mvarBitMap1.Dispose()
				mvarBitMap1 = mvarLedBld1.ledBMP
				chooseLed()
			End Set
		End Property
		Public Property socketFeature() As ledSocketFeature
			Get
				Return mvarSocketFeature
			End Get
			Set(ByVal Value As ledSocketFeature)
				mvarSocketFeature = Value
				mvarLedBld1.socketFeature = Value - 1
				mvarLedBld2.socketFeature = Value - 1
				ledInvalidate()
			End Set
		End Property
		Public Property toolTip() As String
			Get
				Return mvarTooltip
			End Get
			Set(ByVal Value As String)
				mvarTooltip = Value
			End Set
		End Property
		Public Property ledNextTrigger() As ledTrigger
			Get
				Return mvarNextLedStart
			End Get
			Set(ByVal Value As ledTrigger)
				mvarNextLedStart = Value
			End Set
		End Property
		Public Property socketWidth() As ledSocketWidth
			Get
				Return mwarSocketWidth
			End Get
			Set(ByVal Value As ledSocketWidth)
				Dim tmp As Integer
				mwarSocketWidth = Value
				Select Case Value
					Case ledSocketWidth.widthLarge
						tmp = 15
					Case ledSocketWidth.widthMedium
						tmp = 9
					Case ledSocketWidth.widthSmall
						tmp = 5
					Case ledSocketWidth.widthMini
						tmp = 2
				End Select
				mvarLedBld1.socketWidth = tmp
				mvarLedBld2.socketWidth = tmp
				ledInvalidate()
			End Set
		End Property
		Public Property socketColor() As System.Drawing.KnownColor
			Get
				Return mvarSocketColor
			End Get
			Set(ByVal Value As System.Drawing.KnownColor)
				Dim tmp As Color = Color.FromKnownColor(Value)
				mvarSocketColor = Value
				mvarLedBld1.socketColor = tmp
				mvarLedBld2.socketColor = tmp
				ledInvalidate()
			End Set
		End Property
		Public Property ledSize() As ledModel
			Get
				Return mvarSize
			End Get
			Set(ByVal Value As ledModel)
				mvarSize = Value
				OnSizeChanged(Nothing)
				mvarLedBld1.ledSize = mvarBitMapSize
				mvarLedBld2.ledSize = mvarBitMapSize
				ledInvalidate()
			End Set
		End Property
		Public Property ledFlashNext() As String
			Get
				Return mvarNextLedName
			End Get
			Set(ByVal Value As String)
				mvarNextLed = findNextLed(Value)
				mvarNextLedName = Value
			End Set
		End Property
		Public Property ledColor() As mainColor
			Get
				Return mvarColorFirst
			End Get
			Set(ByVal Value As mainColor)
				mvarColorFirst = Value
				mvarColorDark = getDarkColor()
				If mvarColorBlink = blinkColor.colorDark Then
					mvarColorSecond = mvarColorDark
					mvarLedBld2.ledColor = mvarColorSecond
					If Not IsNothing(mvarBitMap2) Then mvarBitMap2.Dispose()
					mvarBitMap2 = mvarLedBld2.ledBMP
				End If
				If mvarModus = ledModus.ledOn Then
					mvarColorAct = CType(mvarColorFirst, allColor)
				Else
					mvarColorAct = CType(mvarColorSecond, allColor)
				End If
				mvarLedBld1.ledColor = mvarColorFirst
				If Not IsNothing(mvarBitMap1) Then mvarBitMap1.Dispose()
				mvarBitMap1 = mvarLedBld1.ledBMP
				chooseLed()
			End Set
		End Property
		Public Property ledColorBlink() As blinkColor
			Get
				Return mvarColorBlink
			End Get
			Set(ByVal Value As blinkColor)
				mvarColorBlink = Value
				If Value <> blinkColor.colorDark Then
					mvarColorSecond = CType(Value, allColor)
				Else
					mvarColorSecond = getDarkColor()
				End If
				mvarLedBld2.ledColor = mvarColorSecond
				If Not IsNothing(mvarBitMap2) Then mvarBitMap2.Dispose()
				mvarBitMap2 = mvarLedBld2.ledBMP
			End Set
		End Property
		Public Property ledSoundFile() As String
			Get
				Return mvarSoundFile
			End Get
			Set(ByVal Value As String)
				mvarSoundFile = Value
				If mvarSoundRunning Then
					soundOff()
					soundOn()
				End If
			End Set
		End Property
		Public Property ledStatus() As ledModus
			Get
				Return mvarModus
			End Get
			Set(ByVal Value As ledModus)
				blinkTimer.Enabled = False
				mvarOldStatus = mvarModus
				mvarModus = Value
				Select Case mvarModus
					Case ledModus.ledOn
						mvarColorAct = CType(mvarColorFirst, allColor)
						Select Case mvarOldStatus
							Case ledModus.ledOff
								soundOn()
							Case ledModus.ledBlink
								soundOff()
						End Select
						If mvarOldStatus <> ledModus.ledBlink Then testBeep()
					Case ledModus.ledOff
						mvarColorAct = mvarColorDark
						soundOff()
					Case ledModus.ledFlash
						mvarColorAct = CType(mvarColorFirst, allColor)
						If mvarBlinkSignal = ledAudio.soundOn Then soundOn()
						testBeep()
					Case ledModus.ledBlink
						mvarColorAct = CType(mvarColorFirst, allColor)
						soundOn()
						testBeep()
				End Select
				chooseLed()
				ledBlink()
			End Set
		End Property
		Public Property ledBeep() As ledAudio
			Get
				Return mvarBlinkSignal
			End Get
			Set(ByVal Value As ledAudio)
				mvarBlinkSignal = Value
				Select Case Value
					Case ledAudio.audioOff, ledAudio.beepOn
						soundOff()
					Case ledAudio.soundOn
						If mvarModus = ledModus.ledBlink Then soundOn()
				End Select
			End Set
		End Property
		Public Property ledBlinkSpeed() As blinkSpeed
			Get
				Return mvarBlSpeed
			End Get
			Set(ByVal Value As blinkSpeed)
				mvarBlSpeed = Value
				mvarBlinkInterval = 2 ^ Value
				ledBlink()
			End Set
		End Property
		Public Property ledDesignBehaviour() As ledDesignMode
			Get
				Return mvarLive
			End Get
			Set(ByVal Value As ledDesignMode)
				mvarLive = Value
			End Set
		End Property
		Public Property ledBackTransparent() As Boolean
			Get
				Return mvarTransparent
			End Get
			Set(ByVal Value As Boolean)
				mvarTransparent = Value
				setTransparent(Value)
			End Set
		End Property
#End Region
#Region "Public Methods"
		Public Sub ledSwitch()
			If mvarIsFirst Then
				mvarColorAct = CType(mvarColorSecond, allColor)
				If mvarModus = ledModus.ledFlash Then
					If mvarNextLedStart = ledTrigger.nextDirect Then
						testEvent()
					End If
				End If
			Else
				If mvarModus = ledModus.ledFlash Then
					If mvarNextLedStart = ledTrigger.nextDelay Then
						testEvent()
						mvarModus = ledModus.ledOff
					End If
				Else
					mvarColorAct = CType(mvarColorFirst, allColor)
					testBeep()
				End If
			End If
			chooseLed()
		End Sub
#End Region
#Region "Private Functions"
		Private Sub setTransparent(ByVal trans As Boolean)
			Dim bc As System.Drawing.Color
			If trans Then
				If IsNothing(Me.Parent) Then
					Exit Sub
				Else
					bc = Me.Parent.BackColor
				End If
			Else
				bc = BackColor
			End If
			mvarLedBld1.backColor = bc
			mvarLedBld2.backColor = bc
			If Not IsNothing(mvarBitMap2) Then mvarBitMap2.Dispose()
			mvarBitMap2 = mvarLedBld2.ledBMP
			If Not IsNothing(mvarBitMap1) Then mvarBitMap1.Dispose()
			mvarBitMap1 = mvarLedBld1.ledBMP
			chooseLed()
		End Sub
		Private Sub initColor()
			ledSize = ledSize.sizeMedium
			socketFeature = ledSocketFeature.sockedDeepened
			'socketColor = ledSocketColor.colorSilver
			socketColor = KnownColor.Silver
			socketWidth = ledSocketWidth.widthMedium
			ledBlink()
		End Sub
		Private Sub chooseLed()
			mvarIsFirst = (mvarColorAct = mvarColorFirst)
			If mvarIsFirst Then
				pictLeds.Image = mvarBitMap1
			Else
				pictLeds.Image = mvarBitMap2
			End If
			pictLeds.Refresh()
		End Sub
		Private Sub ledBlink()
			blinkTimer.Enabled = (mvarModus = (ledModus.ledBlink) Or (mvarModus = ledModus.ledFlash))
			blinkTimer.Interval = mvarBlinkInterval * 100
		End Sub
		Private Function testBlink() As Boolean
			If Not Me.DesignMode Then
				Return True
			Else
				If mvarLive = ledDesignMode.blinkOn_audioOn Or mvarLive = ledDesignMode.blinkOn_audioOff Then Return True
			End If
			Return False
		End Function
		Private Sub testBeep()
			Select Case mvarBlinkSignal
				Case ledAudio.beepOn
					If Not Me.DesignMode Then
						Beep()
					Else
						If mvarLive = ledDesignMode.blinkOn_audioOn Then
							Beep()
						End If
					End If
			End Select
		End Sub
		Private Sub soundOff()
			Dim n As Integer
			If mvarSoundRunning Then cSound.soundOff()
			mvarSoundRunning = False
		End Sub
		Private Sub soundOn()
			Dim n As Integer
			If mvarSoundFile = "" Then Exit Sub
			If mvarBlinkSignal = ledAudio.soundOn Then
				If mvarModus = ledModus.ledFlash Or mvarModus = ledModus.ledOn Then
					cSound.Play(mvarSoundFile, False)
					mvarSoundRunning = False
				Else
					If Not mvarSoundRunning Then
						cSound.Play(mvarSoundFile, True)
						mvarSoundRunning = True
					End If
				End If
			Else
				soundOff()
			End If
		End Sub
		Private Sub testEvent()
			Dim cancel As Boolean = False
			If mvarModus <> ledModus.ledFlash Then Exit Sub
			If mvarNextLedName = "" Then Exit Sub
			If IsNothing(mvarNextLed) Then
				ledFlashNext = mvarNextLedName
			End If
			RaiseEvent FlashNext(mvarNextLedName, cancel)
			If Not cancel Then
				mvarNextLed.ledStatus = ledModus.ledFlash
			End If
		End Sub
		Private Function findMyName(ByVal led As pscLed) As String
			Dim comp As Windows.Forms.Control
			Dim a As Windows.Forms.Form
			If Not IsNothing(Me.ParentForm) Then
				a = Me.ParentForm
				For Each comp In Me.ParentForm.Controls
					If TypeOf (comp) Is pscLed Then
						If comp.Handle.Equals(led.Handle) Then
							Return comp.Name
						End If
					End If
				Next
			End If
		End Function
		Private Function findNextLed(ByVal led As String) As pscLed
			Dim comp As Windows.Forms.Control
			Dim a As Windows.Forms.Form
			If Not IsNothing(Me.ParentForm) Then
				a = Me.ParentForm
				For Each comp In Me.ParentForm.Controls
					If TypeOf (comp) Is pscLed Then
						If StrComp(comp.Name, led, CompareMethod.Text) = 0 Then
							Return CType(comp, pscLed)
						End If
					End If
				Next
			End If
		End Function

		Private Sub ledInvalidate()
			setTransparent(mvarTransparent)
			'If Not IsNothing(mvarBitMap1) Then mvarBitMap1.Dispose()
			'mvarBitMap1 = mvarLedBld1.ledBMP
			'If Not IsNothing(mvarBitMap2) Then mvarBitMap2.Dispose()
			'mvarBitMap2 = mvarLedBld2.ledBMP
			'chooseLed()
		End Sub
		Private Function getDarkColor() As allColor
			Select Case mvarColorFirst
				Case mainColor.colorBlue
					Return allColor.ledDarkBlue
				Case mainColor.colorGreen
					Return allColor.ledDarkGreen
				Case mainColor.colorRed
					Return allColor.ledDarkRed
				Case mainColor.colorYellow
					Return allColor.ledDarkYellow
				Case mainColor.colorMagenta
					Return allColor.ledDarkMagenta
				Case mainColor.colorCyan
					Return allColor.ledDarkCyan
				Case mainColor.colorOrange
					Return allColor.ledDarkOrange
				Case mainColor.colorGrey
					Return allColor.ledDarkGrey
			End Select
		End Function
#End Region
#Region "Private Events"
		Private Sub pictLeds_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pictLeds.Click
			Me.OnClick(e)
		End Sub
		Private Sub blinkTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles blinkTimer.Tick
			Select Case mvarModus
				Case ledModus.ledOff, ledModus.ledOn
					' do nothing
				Case ledModus.ledBlink, ledModus.ledFlash
					If testBlink() Then
						ledSwitch()
					End If
			End Select
		End Sub
		Private Sub pictLeds_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pictLeds.MouseMove
			Me.OnMouseMove(e)
		End Sub

		Private Sub pscLed_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove
			ToolTip1.SetToolTip(pictLeds, mvarTooltip)
		End Sub
#End Region
	End Class
End Namespace
