Imports System.IO
Imports System.Reflection
Imports System.Runtime.InteropServices
Namespace NPSCLed

	Friend Class CSound

		Declare Function PlaySound Lib "winmm.dll" Alias "PlaySoundA" (ByVal lpszName As IntPtr, ByVal hModule As IntPtr, ByVal dwFlags As Integer) As Integer
		Private Const SND_ASYNC = &H1
		Private Const SND_LOOP = &H8
		Private Const SND_PURGE = &H40
		Private Const SND_NOSTOP = &H10
		Private Const SND_MEMORY As Int32 = &H4

		Private Shared m_hgData As IntPtr

		Private Shared Sub stoppPlaying()
			PlaySound(IntPtr.Zero, IntPtr.Zero, SND_PURGE)			' API-Aufruf!
			Marshal.FreeHGlobal(m_hgData)
			m_hgData = IntPtr.Zero
		End Sub

		Public Shared Sub Play(ByVal sName As String, ByVal lp As Boolean)
			Dim inMemory As Boolean
			Dim memFlag As Integer
			Dim strm As Stream
			If Not m_hgData.Equals(IntPtr.Zero) Then stoppPlaying()
			Dim syst As String
			Dim names As String = [Assembly].GetExecutingAssembly().GetName.Name & "."
			If sName.StartsWith(names) Then
				memFlag = SND_MEMORY
				strm = [Assembly].GetExecutingAssembly().GetManifestResourceStream(sName)
			Else
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
			PlaySound(m_hgData, IntPtr.Zero, Flags)			' API-Aufruf!
		End Sub


		Public Shared Sub soundOff()
			If Not m_hgData.Equals(IntPtr.Zero) Then stoppPlaying()
		End Sub

	End Class
End Namespace