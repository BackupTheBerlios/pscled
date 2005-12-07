Imports System.Reflection
Imports NPSCLed.PscLed
Namespace Demo
	Public Class frmLedDemo
		Inherits System.Windows.Forms.Form
#Region " Windows Form Designer generated code "

		Public Sub New()
			MyBase.New()

			'This call is required by the Windows Form Designer.
			InitializeComponent()

			'Add any initialization after the InitializeComponent() call

		End Sub

		'Form overrides dispose to clean up the component list.
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
		Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
		Friend WithEvents cbColor As System.Windows.Forms.ComboBox
		Friend WithEvents Label1 As System.Windows.Forms.Label
		Friend WithEvents Label2 As System.Windows.Forms.Label
		Friend WithEvents cbStatus As System.Windows.Forms.ComboBox
		Friend WithEvents Label3 As System.Windows.Forms.Label
		Friend WithEvents Label4 As System.Windows.Forms.Label
		Friend WithEvents Label5 As System.Windows.Forms.Label
		Friend WithEvents Label7 As System.Windows.Forms.Label
		Friend WithEvents cbSize As System.Windows.Forms.ComboBox
		Friend WithEvents cbBeep As System.Windows.Forms.ComboBox
		Friend WithEvents cbBlink As System.Windows.Forms.ComboBox
		Friend WithEvents cbSpeed As System.Windows.Forms.ComboBox
		Friend WithEvents cmdEnd As System.Windows.Forms.Button
		Friend WithEvents Label6 As System.Windows.Forms.Label
		Friend WithEvents cbSound As System.Windows.Forms.ComboBox
		Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
		Friend WithEvents Label8 As System.Windows.Forms.Label
		Friend WithEvents txtTooltip As System.Windows.Forms.TextBox
		Friend WithEvents Label9 As System.Windows.Forms.Label
		Friend WithEvents cbBorder As System.Windows.Forms.ComboBox
		Friend WithEvents Label10 As System.Windows.Forms.Label
		Friend WithEvents Label11 As System.Windows.Forms.Label
		Friend WithEvents cbSockWidth As System.Windows.Forms.ComboBox
		Friend WithEvents Label12 As System.Windows.Forms.Label
		Friend WithEvents cbSockColor As System.Windows.Forms.ComboBox
		Friend WithEvents cbFeature As System.Windows.Forms.ComboBox
		Friend WithEvents Label13 As System.Windows.Forms.Label
		Friend WithEvents PscLed1 As NPSCLed.PscLed
		Friend WithEvents PscLed2 As NPSCLed.PscLed
		Friend WithEvents PscLed3 As NPSCLed.PscLed
		Friend WithEvents PscLed4 As NPSCLed.PscLed
		Friend WithEvents PscLed5 As NPSCLed.PscLed
		Friend WithEvents PscLed6 As NPSCLed.PscLed
		Friend WithEvents PscLed7 As NPSCLed.PscLed
		Friend WithEvents PscLed8 As NPSCLed.PscLed
		Friend WithEvents PscLed9 As NPSCLed.PscLed
		Friend WithEvents PscLed10 As NPSCLed.PscLed
		Friend WithEvents PscLed11 As NPSCLed.PscLed
		Friend WithEvents PscLed12 As NPSCLed.PscLed
		Friend WithEvents PscLed13 As NPSCLed.PscLed
		Friend WithEvents PscLed14 As NPSCLed.PscLed
		Friend WithEvents PscLed15 As NPSCLed.PscLed
		Friend WithEvents PscLed16 As NPSCLed.PscLed
		Friend WithEvents PscLed17 As NPSCLed.PscLed
		Friend WithEvents cbBackColor As System.Windows.Forms.ComboBox
		<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container
			Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmLedDemo))
			Me.GroupBox1 = New System.Windows.Forms.GroupBox
			Me.PscLed1 = New NPSCLed.PscLed
			Me.cbBackColor = New System.Windows.Forms.ComboBox
			Me.cbFeature = New System.Windows.Forms.ComboBox
			Me.Label13 = New System.Windows.Forms.Label
			Me.cbSockColor = New System.Windows.Forms.ComboBox
			Me.Label12 = New System.Windows.Forms.Label
			Me.cbSockWidth = New System.Windows.Forms.ComboBox
			Me.Label11 = New System.Windows.Forms.Label
			Me.Label10 = New System.Windows.Forms.Label
			Me.Label9 = New System.Windows.Forms.Label
			Me.cbBorder = New System.Windows.Forms.ComboBox
			Me.txtTooltip = New System.Windows.Forms.TextBox
			Me.Label8 = New System.Windows.Forms.Label
			Me.cbSound = New System.Windows.Forms.ComboBox
			Me.Label6 = New System.Windows.Forms.Label
			Me.Label7 = New System.Windows.Forms.Label
			Me.cbSize = New System.Windows.Forms.ComboBox
			Me.Label5 = New System.Windows.Forms.Label
			Me.cbBeep = New System.Windows.Forms.ComboBox
			Me.Label4 = New System.Windows.Forms.Label
			Me.cbSpeed = New System.Windows.Forms.ComboBox
			Me.Label3 = New System.Windows.Forms.Label
			Me.cbBlink = New System.Windows.Forms.ComboBox
			Me.Label2 = New System.Windows.Forms.Label
			Me.cbStatus = New System.Windows.Forms.ComboBox
			Me.Label1 = New System.Windows.Forms.Label
			Me.cbColor = New System.Windows.Forms.ComboBox
			Me.cmdEnd = New System.Windows.Forms.Button
			Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
			Me.PscLed2 = New NPSCLed.PscLed
			Me.PscLed3 = New NPSCLed.PscLed
			Me.PscLed4 = New NPSCLed.PscLed
			Me.PscLed5 = New NPSCLed.PscLed
			Me.PscLed6 = New NPSCLed.PscLed
			Me.PscLed7 = New NPSCLed.PscLed
			Me.PscLed8 = New NPSCLed.PscLed
			Me.PscLed9 = New NPSCLed.PscLed
			Me.PscLed10 = New NPSCLed.PscLed
			Me.PscLed11 = New NPSCLed.PscLed
			Me.PscLed12 = New NPSCLed.PscLed
			Me.PscLed13 = New NPSCLed.PscLed
			Me.PscLed14 = New NPSCLed.PscLed
			Me.PscLed15 = New NPSCLed.PscLed
			Me.PscLed16 = New NPSCLed.PscLed
			Me.PscLed17 = New NPSCLed.PscLed
			Me.GroupBox1.SuspendLayout()
			Me.SuspendLayout()
			'
			'GroupBox1
			'
			Me.GroupBox1.Controls.Add(Me.PscLed1)
			Me.GroupBox1.Controls.Add(Me.cbBackColor)
			Me.GroupBox1.Controls.Add(Me.cbFeature)
			Me.GroupBox1.Controls.Add(Me.Label13)
			Me.GroupBox1.Controls.Add(Me.cbSockColor)
			Me.GroupBox1.Controls.Add(Me.Label12)
			Me.GroupBox1.Controls.Add(Me.cbSockWidth)
			Me.GroupBox1.Controls.Add(Me.Label11)
			Me.GroupBox1.Controls.Add(Me.Label10)
			Me.GroupBox1.Controls.Add(Me.Label9)
			Me.GroupBox1.Controls.Add(Me.cbBorder)
			Me.GroupBox1.Controls.Add(Me.txtTooltip)
			Me.GroupBox1.Controls.Add(Me.Label8)
			Me.GroupBox1.Controls.Add(Me.cbSound)
			Me.GroupBox1.Controls.Add(Me.Label6)
			Me.GroupBox1.Controls.Add(Me.Label7)
			Me.GroupBox1.Controls.Add(Me.cbSize)
			Me.GroupBox1.Controls.Add(Me.Label5)
			Me.GroupBox1.Controls.Add(Me.cbBeep)
			Me.GroupBox1.Controls.Add(Me.Label4)
			Me.GroupBox1.Controls.Add(Me.cbSpeed)
			Me.GroupBox1.Controls.Add(Me.Label3)
			Me.GroupBox1.Controls.Add(Me.cbBlink)
			Me.GroupBox1.Controls.Add(Me.Label2)
			Me.GroupBox1.Controls.Add(Me.cbStatus)
			Me.GroupBox1.Controls.Add(Me.Label1)
			Me.GroupBox1.Controls.Add(Me.cbColor)
			Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
			Me.GroupBox1.Location = New System.Drawing.Point(55, 16)
			Me.GroupBox1.Name = "GroupBox1"
			Me.GroupBox1.Size = New System.Drawing.Size(553, 350)
			Me.GroupBox1.TabIndex = 18
			Me.GroupBox1.TabStop = False
			Me.GroupBox1.Text = "Build Your Own LED"
			'
			'PscLed1
			'
			Me.PscLed1.CausesValidation = False
			Me.PscLed1.ledBackTransparent = False
			Me.PscLed1.ledBeep = ledAudio.audioOff
			Me.PscLed1.ledBlinkSpeed = blinkSpeed.blinkVeryFast
			Me.PscLed1.ledBorder = ledBorderStyle.Socket
			Me.PscLed1.ledColor = mainColor.colorRed
			Me.PscLed1.ledColorBlink = blinkColor.colorDark
			Me.PscLed1.ledDesignBehaviour = ledDesignMode.blinkOn_audioOff
			Me.PscLed1.ledFlashNext = Nothing
			Me.PscLed1.ledNextTrigger = ledTrigger.nextDirect
			Me.PscLed1.ledSize = ledModel.sizeMaxi
			Me.PscLed1.ledSoundFile = ""
			Me.PscLed1.ledStatus = ledModus.ledOn
			Me.PscLed1.Location = New System.Drawing.Point(16, 210)
			Me.PscLed1.Name = "PscLed1"
			Me.PscLed1.Size = New System.Drawing.Size(128, 128)
			Me.PscLed1.socketColor = System.Drawing.KnownColor.Silver
			Me.PscLed1.socketFeature = ledSocketFeature.sockedDeepened
			Me.PscLed1.socketWidth = ledSocketWidth.widthMedium
			Me.PscLed1.TabIndex = 36
			Me.PscLed1.toolTip = Nothing
			'
			'cbBackColor
			'
			Me.cbBackColor.Location = New System.Drawing.Point(424, 206)
			Me.cbBackColor.Name = "cbBackColor"
			Me.cbBackColor.Size = New System.Drawing.Size(108, 21)
			Me.cbBackColor.TabIndex = 35
			'
			'cbFeature
			'
			Me.cbFeature.Location = New System.Drawing.Point(424, 26)
			Me.cbFeature.Name = "cbFeature"
			Me.cbFeature.Size = New System.Drawing.Size(108, 21)
			Me.cbFeature.TabIndex = 34
			'
			'Label13
			'
			Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
			Me.Label13.Location = New System.Drawing.Point(272, 26)
			Me.Label13.Name = "Label13"
			Me.Label13.Size = New System.Drawing.Size(142, 16)
			Me.Label13.TabIndex = 33
			Me.Label13.Text = "Choose Socked Feature"
			'
			'cbSockColor
			'
			Me.cbSockColor.Location = New System.Drawing.Point(424, 56)
			Me.cbSockColor.Name = "cbSockColor"
			Me.cbSockColor.Size = New System.Drawing.Size(108, 21)
			Me.cbSockColor.TabIndex = 32
			'
			'Label12
			'
			Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
			Me.Label12.Location = New System.Drawing.Point(272, 56)
			Me.Label12.Name = "Label12"
			Me.Label12.Size = New System.Drawing.Size(124, 16)
			Me.Label12.TabIndex = 31
			Me.Label12.Text = "Choose Socket Color"
			'
			'cbSockWidth
			'
			Me.cbSockWidth.Location = New System.Drawing.Point(424, 86)
			Me.cbSockWidth.Name = "cbSockWidth"
			Me.cbSockWidth.Size = New System.Drawing.Size(108, 21)
			Me.cbSockWidth.TabIndex = 28
			'
			'Label11
			'
			Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
			Me.Label11.Location = New System.Drawing.Point(272, 86)
			Me.Label11.Name = "Label11"
			Me.Label11.Size = New System.Drawing.Size(128, 16)
			Me.Label11.TabIndex = 27
			Me.Label11.Text = "ChooseSocket Width"
			'
			'Label10
			'
			Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
			Me.Label10.Location = New System.Drawing.Point(272, 210)
			Me.Label10.Name = "Label10"
			Me.Label10.Size = New System.Drawing.Size(114, 16)
			Me.Label10.TabIndex = 23
			Me.Label10.Text = "Choose BackColor"
			'
			'Label9
			'
			Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
			Me.Label9.Location = New System.Drawing.Point(16, 176)
			Me.Label9.Name = "Label9"
			Me.Label9.Size = New System.Drawing.Size(114, 16)
			Me.Label9.TabIndex = 21
			Me.Label9.Text = "Choose Border"
			'
			'cbBorder
			'
			Me.cbBorder.Location = New System.Drawing.Point(144, 176)
			Me.cbBorder.Name = "cbBorder"
			Me.cbBorder.Size = New System.Drawing.Size(108, 21)
			Me.cbBorder.TabIndex = 20
			'
			'txtTooltip
			'
			Me.txtTooltip.Location = New System.Drawing.Point(424, 176)
			Me.txtTooltip.Name = "txtTooltip"
			Me.txtTooltip.Size = New System.Drawing.Size(108, 20)
			Me.txtTooltip.TabIndex = 18
			Me.txtTooltip.Text = "You need this LED"
			'
			'Label8
			'
			Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
			Me.Label8.Location = New System.Drawing.Point(272, 176)
			Me.Label8.Name = "Label8"
			Me.Label8.Size = New System.Drawing.Size(128, 16)
			Me.Label8.TabIndex = 17
			Me.Label8.Text = "Choose ToolTip"
			'
			'cbSound
			'
			Me.cbSound.Location = New System.Drawing.Point(424, 146)
			Me.cbSound.Name = "cbSound"
			Me.cbSound.Size = New System.Drawing.Size(108, 21)
			Me.cbSound.TabIndex = 16
			'
			'Label6
			'
			Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
			Me.Label6.Location = New System.Drawing.Point(272, 146)
			Me.Label6.Name = "Label6"
			Me.Label6.Size = New System.Drawing.Size(128, 16)
			Me.Label6.TabIndex = 15
			Me.Label6.Text = "Choose Sound"
			'
			'Label7
			'
			Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
			Me.Label7.Location = New System.Drawing.Point(16, 26)
			Me.Label7.Name = "Label7"
			Me.Label7.Size = New System.Drawing.Size(88, 16)
			Me.Label7.TabIndex = 14
			Me.Label7.Text = "Choose Size"
			'
			'cbSize
			'
			Me.cbSize.Location = New System.Drawing.Point(144, 26)
			Me.cbSize.Name = "cbSize"
			Me.cbSize.Size = New System.Drawing.Size(108, 21)
			Me.cbSize.TabIndex = 13
			'
			'Label5
			'
			Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
			Me.Label5.Location = New System.Drawing.Point(272, 116)
			Me.Label5.Name = "Label5"
			Me.Label5.Size = New System.Drawing.Size(88, 16)
			Me.Label5.TabIndex = 10
			Me.Label5.Text = "Choose Audio"
			'
			'cbBeep
			'
			Me.cbBeep.Location = New System.Drawing.Point(424, 116)
			Me.cbBeep.Name = "cbBeep"
			Me.cbBeep.Size = New System.Drawing.Size(108, 21)
			Me.cbBeep.TabIndex = 9
			'
			'Label4
			'
			Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
			Me.Label4.Location = New System.Drawing.Point(16, 146)
			Me.Label4.Name = "Label4"
			Me.Label4.Size = New System.Drawing.Size(114, 16)
			Me.Label4.TabIndex = 8
			Me.Label4.Text = "Choose Blink Speed"
			'
			'cbSpeed
			'
			Me.cbSpeed.Location = New System.Drawing.Point(144, 146)
			Me.cbSpeed.Name = "cbSpeed"
			Me.cbSpeed.Size = New System.Drawing.Size(108, 21)
			Me.cbSpeed.TabIndex = 7
			'
			'Label3
			'
			Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
			Me.Label3.Location = New System.Drawing.Point(16, 116)
			Me.Label3.Name = "Label3"
			Me.Label3.Size = New System.Drawing.Size(110, 16)
			Me.Label3.TabIndex = 6
			Me.Label3.Text = "Choose Blink Color"
			'
			'cbBlink
			'
			Me.cbBlink.Location = New System.Drawing.Point(144, 116)
			Me.cbBlink.Name = "cbBlink"
			Me.cbBlink.Size = New System.Drawing.Size(108, 21)
			Me.cbBlink.TabIndex = 5
			'
			'Label2
			'
			Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
			Me.Label2.Location = New System.Drawing.Point(16, 86)
			Me.Label2.Name = "Label2"
			Me.Label2.Size = New System.Drawing.Size(88, 16)
			Me.Label2.TabIndex = 4
			Me.Label2.Text = "Choose Status"
			'
			'cbStatus
			'
			Me.cbStatus.Location = New System.Drawing.Point(144, 86)
			Me.cbStatus.Name = "cbStatus"
			Me.cbStatus.Size = New System.Drawing.Size(108, 21)
			Me.cbStatus.TabIndex = 3
			'
			'Label1
			'
			Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
			Me.Label1.Location = New System.Drawing.Point(16, 56)
			Me.Label1.Name = "Label1"
			Me.Label1.Size = New System.Drawing.Size(88, 16)
			Me.Label1.TabIndex = 2
			Me.Label1.Text = "Choose Color"
			'
			'cbColor
			'
			Me.cbColor.Location = New System.Drawing.Point(144, 56)
			Me.cbColor.Name = "cbColor"
			Me.cbColor.Size = New System.Drawing.Size(108, 21)
			Me.cbColor.TabIndex = 0
			'
			'cmdEnd
			'
			Me.cmdEnd.DialogResult = System.Windows.Forms.DialogResult.Cancel
			Me.cmdEnd.Location = New System.Drawing.Point(528, 374)
			Me.cmdEnd.Name = "cmdEnd"
			Me.cmdEnd.Size = New System.Drawing.Size(88, 22)
			Me.cmdEnd.TabIndex = 20
			Me.cmdEnd.Text = "Exit"
			'
			'PscLed2
			'
			Me.PscLed2.CausesValidation = False
			Me.PscLed2.ledBackTransparent = False
			Me.PscLed2.ledBeep = ledAudio.audioOff
			Me.PscLed2.ledBlinkSpeed = blinkSpeed.blinkFast
			Me.PscLed2.ledBorder = ledBorderStyle.None
			Me.PscLed2.ledColor = mainColor.colorRed
			Me.PscLed2.ledColorBlink = blinkColor.colorDark
			Me.PscLed2.ledDesignBehaviour = ledDesignMode.blinkOn_audioOff
			Me.PscLed2.ledFlashNext = Nothing
			Me.PscLed2.ledNextTrigger = ledTrigger.nextDirect
			Me.PscLed2.ledSize = ledModel.sizeSmall
			Me.PscLed2.ledSoundFile = ""
			Me.PscLed2.ledStatus = ledModus.ledOn
			Me.PscLed2.Location = New System.Drawing.Point(10, 16)
			Me.PscLed2.Name = "PscLed2"
			Me.PscLed2.Size = New System.Drawing.Size(16, 16)
			Me.PscLed2.socketColor = System.Drawing.KnownColor.Silver
			Me.PscLed2.socketFeature = ledSocketFeature.sockedDeepened
			Me.PscLed2.socketWidth = ledSocketWidth.widthMedium
			Me.PscLed2.TabIndex = 22
			Me.PscLed2.toolTip = Nothing
			'
			'PscLed3
			'
			Me.PscLed3.CausesValidation = False
			Me.PscLed3.ledBackTransparent = False
			Me.PscLed3.ledBeep = ledAudio.audioOff
			Me.PscLed3.ledBlinkSpeed = blinkSpeed.blinkFast
			Me.PscLed3.ledBorder = ledBorderStyle.None
			Me.PscLed3.ledColor = mainColor.colorGreen
			Me.PscLed3.ledColorBlink = blinkColor.colorDark
			Me.PscLed3.ledDesignBehaviour = ledDesignMode.blinkOn_audioOff
			Me.PscLed3.ledFlashNext = Nothing
			Me.PscLed3.ledNextTrigger = ledTrigger.nextDirect
			Me.PscLed3.ledSize = ledModel.sizeSmall
			Me.PscLed3.ledSoundFile = ""
			Me.PscLed3.ledStatus = ledModus.ledOff
			Me.PscLed3.Location = New System.Drawing.Point(10, 62)
			Me.PscLed3.Name = "PscLed3"
			Me.PscLed3.Size = New System.Drawing.Size(16, 16)
			Me.PscLed3.socketColor = System.Drawing.KnownColor.Silver
			Me.PscLed3.socketFeature = ledSocketFeature.sockedDeepened
			Me.PscLed3.socketWidth = ledSocketWidth.widthMedium
			Me.PscLed3.TabIndex = 23
			Me.PscLed3.toolTip = Nothing
			'
			'PscLed4
			'
			Me.PscLed4.CausesValidation = False
			Me.PscLed4.ledBackTransparent = False
			Me.PscLed4.ledBeep = ledAudio.audioOff
			Me.PscLed4.ledBlinkSpeed = blinkSpeed.blinkFast
			Me.PscLed4.ledBorder = ledBorderStyle.None
			Me.PscLed4.ledColor = mainColor.colorBlue
			Me.PscLed4.ledColorBlink = blinkColor.colorDark
			Me.PscLed4.ledDesignBehaviour = ledDesignMode.blinkOn_audioOff
			Me.PscLed4.ledFlashNext = Nothing
			Me.PscLed4.ledNextTrigger = ledTrigger.nextDirect
			Me.PscLed4.ledSize = ledModel.sizeSmall
			Me.PscLed4.ledSoundFile = ""
			Me.PscLed4.ledStatus = ledModus.ledOff
			Me.PscLed4.Location = New System.Drawing.Point(10, 108)
			Me.PscLed4.Name = "PscLed4"
			Me.PscLed4.Size = New System.Drawing.Size(16, 16)
			Me.PscLed4.socketColor = System.Drawing.KnownColor.Silver
			Me.PscLed4.socketFeature = ledSocketFeature.sockedDeepened
			Me.PscLed4.socketWidth = ledSocketWidth.widthMedium
			Me.PscLed4.TabIndex = 25
			Me.PscLed4.toolTip = Nothing
			'
			'PscLed5
			'
			Me.PscLed5.CausesValidation = False
			Me.PscLed5.ledBackTransparent = False
			Me.PscLed5.ledBeep = ledAudio.audioOff
			Me.PscLed5.ledBlinkSpeed = blinkSpeed.blinkFast
			Me.PscLed5.ledBorder = ledBorderStyle.None
			Me.PscLed5.ledColor = mainColor.colorYellow
			Me.PscLed5.ledColorBlink = blinkColor.colorDark
			Me.PscLed5.ledDesignBehaviour = ledDesignMode.blinkOn_audioOff
			Me.PscLed5.ledFlashNext = Nothing
			Me.PscLed5.ledNextTrigger = ledTrigger.nextDirect
			Me.PscLed5.ledSize = ledModel.sizeSmall
			Me.PscLed5.ledSoundFile = ""
			Me.PscLed5.ledStatus = ledModus.ledOff
			Me.PscLed5.Location = New System.Drawing.Point(10, 154)
			Me.PscLed5.Name = "PscLed5"
			Me.PscLed5.Size = New System.Drawing.Size(16, 16)
			Me.PscLed5.socketColor = System.Drawing.KnownColor.Silver
			Me.PscLed5.socketFeature = ledSocketFeature.sockedDeepened
			Me.PscLed5.socketWidth = ledSocketWidth.widthMedium
			Me.PscLed5.TabIndex = 24
			Me.PscLed5.toolTip = Nothing
			'
			'PscLed6
			'
			Me.PscLed6.CausesValidation = False
			Me.PscLed6.ledBackTransparent = False
			Me.PscLed6.ledBeep = ledAudio.audioOff
			Me.PscLed6.ledBlinkSpeed = blinkSpeed.blinkFast
			Me.PscLed6.ledBorder = ledBorderStyle.None
			Me.PscLed6.ledColor = mainColor.colorMagenta
			Me.PscLed6.ledColorBlink = blinkColor.colorDark
			Me.PscLed6.ledDesignBehaviour = ledDesignMode.blinkOn_audioOff
			Me.PscLed6.ledFlashNext = Nothing
			Me.PscLed6.ledNextTrigger = ledTrigger.nextDirect
			Me.PscLed6.ledSize = ledModel.sizeSmall
			Me.PscLed6.ledSoundFile = ""
			Me.PscLed6.ledStatus = ledModus.ledOff
			Me.PscLed6.Location = New System.Drawing.Point(10, 200)
			Me.PscLed6.Name = "PscLed6"
			Me.PscLed6.Size = New System.Drawing.Size(16, 16)
			Me.PscLed6.socketColor = System.Drawing.KnownColor.Silver
			Me.PscLed6.socketFeature = ledSocketFeature.sockedDeepened
			Me.PscLed6.socketWidth = ledSocketWidth.widthMedium
			Me.PscLed6.TabIndex = 29
			Me.PscLed6.toolTip = Nothing
			'
			'PscLed7
			'
			Me.PscLed7.CausesValidation = False
			Me.PscLed7.ledBackTransparent = False
			Me.PscLed7.ledBeep = ledAudio.audioOff
			Me.PscLed7.ledBlinkSpeed = blinkSpeed.blinkFast
			Me.PscLed7.ledBorder = ledBorderStyle.None
			Me.PscLed7.ledColor = mainColor.colorCyan
			Me.PscLed7.ledColorBlink = blinkColor.colorDark
			Me.PscLed7.ledDesignBehaviour = ledDesignMode.blinkOn_audioOff
			Me.PscLed7.ledFlashNext = Nothing
			Me.PscLed7.ledNextTrigger = ledTrigger.nextDirect
			Me.PscLed7.ledSize = ledModel.sizeSmall
			Me.PscLed7.ledSoundFile = ""
			Me.PscLed7.ledStatus = ledModus.ledOff
			Me.PscLed7.Location = New System.Drawing.Point(10, 246)
			Me.PscLed7.Name = "PscLed7"
			Me.PscLed7.Size = New System.Drawing.Size(16, 16)
			Me.PscLed7.socketColor = System.Drawing.KnownColor.Silver
			Me.PscLed7.socketFeature = ledSocketFeature.sockedDeepened
			Me.PscLed7.socketWidth = ledSocketWidth.widthMedium
			Me.PscLed7.TabIndex = 28
			Me.PscLed7.toolTip = Nothing
			'
			'PscLed8
			'
			Me.PscLed8.CausesValidation = False
			Me.PscLed8.ledBackTransparent = False
			Me.PscLed8.ledBeep = ledAudio.audioOff
			Me.PscLed8.ledBlinkSpeed = blinkSpeed.blinkFast
			Me.PscLed8.ledBorder = ledBorderStyle.None
			Me.PscLed8.ledColor = mainColor.colorOrange
			Me.PscLed8.ledColorBlink = blinkColor.colorDark
			Me.PscLed8.ledDesignBehaviour = ledDesignMode.blinkOn_audioOff
			Me.PscLed8.ledFlashNext = Nothing
			Me.PscLed8.ledNextTrigger = ledTrigger.nextDirect
			Me.PscLed8.ledSize = ledModel.sizeSmall
			Me.PscLed8.ledSoundFile = ""
			Me.PscLed8.ledStatus = ledModus.ledOff
			Me.PscLed8.Location = New System.Drawing.Point(10, 292)
			Me.PscLed8.Name = "PscLed8"
			Me.PscLed8.Size = New System.Drawing.Size(16, 16)
			Me.PscLed8.socketColor = System.Drawing.KnownColor.Silver
			Me.PscLed8.socketFeature = ledSocketFeature.sockedDeepened
			Me.PscLed8.socketWidth = ledSocketWidth.widthMedium
			Me.PscLed8.TabIndex = 27
			Me.PscLed8.toolTip = Nothing
			'
			'PscLed9
			'
			Me.PscLed9.CausesValidation = False
			Me.PscLed9.ledBackTransparent = False
			Me.PscLed9.ledBeep = ledAudio.audioOff
			Me.PscLed9.ledBlinkSpeed = blinkSpeed.blinkFast
			Me.PscLed9.ledBorder = ledBorderStyle.None
			Me.PscLed9.ledColor = mainColor.colorGrey
			Me.PscLed9.ledColorBlink = blinkColor.colorDark
			Me.PscLed9.ledDesignBehaviour = ledDesignMode.blinkOn_audioOff
			Me.PscLed9.ledFlashNext = Nothing
			Me.PscLed9.ledNextTrigger = ledTrigger.nextDirect
			Me.PscLed9.ledSize = ledModel.sizeSmall
			Me.PscLed9.ledSoundFile = ""
			Me.PscLed9.ledStatus = ledModus.ledOff
			Me.PscLed9.Location = New System.Drawing.Point(12, 338)
			Me.PscLed9.Name = "PscLed9"
			Me.PscLed9.Size = New System.Drawing.Size(16, 16)
			Me.PscLed9.socketColor = System.Drawing.KnownColor.Silver
			Me.PscLed9.socketFeature = ledSocketFeature.sockedDeepened
			Me.PscLed9.socketWidth = ledSocketWidth.widthMedium
			Me.PscLed9.TabIndex = 26
			Me.PscLed9.toolTip = Nothing
			'
			'PscLed10
			'
			Me.PscLed10.CausesValidation = False
			Me.PscLed10.ledBackTransparent = False
			Me.PscLed10.ledBeep = ledAudio.audioOff
			Me.PscLed10.ledBlinkSpeed = blinkSpeed.blinkFast
			Me.PscLed10.ledBorder = ledBorderStyle.None
			Me.PscLed10.ledColor = mainColor.colorMagenta
			Me.PscLed10.ledColorBlink = blinkColor.colorDark
			Me.PscLed10.ledDesignBehaviour = ledDesignMode.blinkOn_audioOff
			Me.PscLed10.ledFlashNext = Nothing
			Me.PscLed10.ledNextTrigger = ledTrigger.nextDelay
			Me.PscLed10.ledSize = ledModel.sizeSmall
			Me.PscLed10.ledSoundFile = ""
			Me.PscLed10.ledStatus = ledModus.ledOff
			Me.PscLed10.Location = New System.Drawing.Point(626, 338)
			Me.PscLed10.Name = "PscLed10"
			Me.PscLed10.Size = New System.Drawing.Size(16, 16)
			Me.PscLed10.socketColor = System.Drawing.KnownColor.Silver
			Me.PscLed10.socketFeature = ledSocketFeature.sockedDeepened
			Me.PscLed10.socketWidth = ledSocketWidth.widthMedium
			Me.PscLed10.TabIndex = 37
			Me.PscLed10.toolTip = Nothing
			'
			'PscLed11
			'
			Me.PscLed11.CausesValidation = False
			Me.PscLed11.ledBackTransparent = False
			Me.PscLed11.ledBeep = ledAudio.audioOff
			Me.PscLed11.ledBlinkSpeed = blinkSpeed.blinkFast
			Me.PscLed11.ledBorder = ledBorderStyle.None
			Me.PscLed11.ledColor = mainColor.colorCyan
			Me.PscLed11.ledColorBlink = blinkColor.colorDark
			Me.PscLed11.ledDesignBehaviour = ledDesignMode.blinkOn_audioOff
			Me.PscLed11.ledFlashNext = Nothing
			Me.PscLed11.ledNextTrigger = ledTrigger.nextDelay
			Me.PscLed11.ledSize = ledModel.sizeSmall
			Me.PscLed11.ledSoundFile = ""
			Me.PscLed11.ledStatus = ledModus.ledOff
			Me.PscLed11.Location = New System.Drawing.Point(626, 292)
			Me.PscLed11.Name = "PscLed11"
			Me.PscLed11.Size = New System.Drawing.Size(16, 16)
			Me.PscLed11.socketColor = System.Drawing.KnownColor.Silver
			Me.PscLed11.socketFeature = ledSocketFeature.sockedDeepened
			Me.PscLed11.socketWidth = ledSocketWidth.widthMedium
			Me.PscLed11.TabIndex = 36
			Me.PscLed11.toolTip = Nothing
			'
			'PscLed12
			'
			Me.PscLed12.CausesValidation = False
			Me.PscLed12.ledBackTransparent = False
			Me.PscLed12.ledBeep = ledAudio.audioOff
			Me.PscLed12.ledBlinkSpeed = blinkSpeed.blinkFast
			Me.PscLed12.ledBorder = ledBorderStyle.None
			Me.PscLed12.ledColor = mainColor.colorOrange
			Me.PscLed12.ledColorBlink = blinkColor.colorDark
			Me.PscLed12.ledDesignBehaviour = ledDesignMode.blinkOn_audioOff
			Me.PscLed12.ledFlashNext = Nothing
			Me.PscLed12.ledNextTrigger = ledTrigger.nextDelay
			Me.PscLed12.ledSize = ledModel.sizeSmall
			Me.PscLed12.ledSoundFile = ""
			Me.PscLed12.ledStatus = ledModus.ledOff
			Me.PscLed12.Location = New System.Drawing.Point(626, 246)
			Me.PscLed12.Name = "PscLed12"
			Me.PscLed12.Size = New System.Drawing.Size(16, 16)
			Me.PscLed12.socketColor = System.Drawing.KnownColor.Silver
			Me.PscLed12.socketFeature = ledSocketFeature.sockedDeepened
			Me.PscLed12.socketWidth = ledSocketWidth.widthMedium
			Me.PscLed12.TabIndex = 35
			Me.PscLed12.toolTip = Nothing
			'
			'PscLed13
			'
			Me.PscLed13.CausesValidation = False
			Me.PscLed13.ledBackTransparent = False
			Me.PscLed13.ledBeep = ledAudio.audioOff
			Me.PscLed13.ledBlinkSpeed = blinkSpeed.blinkFast
			Me.PscLed13.ledBorder = ledBorderStyle.None
			Me.PscLed13.ledColor = mainColor.colorGrey
			Me.PscLed13.ledColorBlink = blinkColor.colorDark
			Me.PscLed13.ledDesignBehaviour = ledDesignMode.blinkOn_audioOff
			Me.PscLed13.ledFlashNext = Nothing
			Me.PscLed13.ledNextTrigger = ledTrigger.nextDelay
			Me.PscLed13.ledSize = ledModel.sizeSmall
			Me.PscLed13.ledSoundFile = ""
			Me.PscLed13.ledStatus = ledModus.ledOff
			Me.PscLed13.Location = New System.Drawing.Point(626, 200)
			Me.PscLed13.Name = "PscLed13"
			Me.PscLed13.Size = New System.Drawing.Size(16, 16)
			Me.PscLed13.socketColor = System.Drawing.KnownColor.Silver
			Me.PscLed13.socketFeature = ledSocketFeature.sockedDeepened
			Me.PscLed13.socketWidth = ledSocketWidth.widthMedium
			Me.PscLed13.TabIndex = 34
			Me.PscLed13.toolTip = Nothing
			'
			'PscLed14
			'
			Me.PscLed14.CausesValidation = False
			Me.PscLed14.ledBackTransparent = False
			Me.PscLed14.ledBeep = ledAudio.audioOff
			Me.PscLed14.ledBlinkSpeed = blinkSpeed.blinkFast
			Me.PscLed14.ledBorder = ledBorderStyle.None
			Me.PscLed14.ledColor = mainColor.colorBlue
			Me.PscLed14.ledColorBlink = blinkColor.colorDark
			Me.PscLed14.ledDesignBehaviour = ledDesignMode.blinkOn_audioOff
			Me.PscLed14.ledFlashNext = Nothing
			Me.PscLed14.ledNextTrigger = ledTrigger.nextDelay
			Me.PscLed14.ledSize = ledModel.sizeSmall
			Me.PscLed14.ledSoundFile = ""
			Me.PscLed14.ledStatus = ledModus.ledOff
			Me.PscLed14.Location = New System.Drawing.Point(626, 154)
			Me.PscLed14.Name = "PscLed14"
			Me.PscLed14.Size = New System.Drawing.Size(16, 16)
			Me.PscLed14.socketColor = System.Drawing.KnownColor.Silver
			Me.PscLed14.socketFeature = ledSocketFeature.sockedDeepened
			Me.PscLed14.socketWidth = ledSocketWidth.widthMedium
			Me.PscLed14.TabIndex = 33
			Me.PscLed14.toolTip = Nothing
			'
			'PscLed15
			'
			Me.PscLed15.CausesValidation = False
			Me.PscLed15.ledBackTransparent = False
			Me.PscLed15.ledBeep = ledAudio.audioOff
			Me.PscLed15.ledBlinkSpeed = blinkSpeed.blinkFast
			Me.PscLed15.ledBorder = ledBorderStyle.None
			Me.PscLed15.ledColor = mainColor.colorYellow
			Me.PscLed15.ledColorBlink = blinkColor.colorDark
			Me.PscLed15.ledDesignBehaviour = ledDesignMode.blinkOn_audioOff
			Me.PscLed15.ledFlashNext = Nothing
			Me.PscLed15.ledNextTrigger = ledTrigger.nextDelay
			Me.PscLed15.ledSize = ledModel.sizeSmall
			Me.PscLed15.ledSoundFile = ""
			Me.PscLed15.ledStatus = ledModus.ledOff
			Me.PscLed15.Location = New System.Drawing.Point(626, 108)
			Me.PscLed15.Name = "PscLed15"
			Me.PscLed15.Size = New System.Drawing.Size(16, 16)
			Me.PscLed15.socketColor = System.Drawing.KnownColor.Silver
			Me.PscLed15.socketFeature = ledSocketFeature.sockedDeepened
			Me.PscLed15.socketWidth = ledSocketWidth.widthMedium
			Me.PscLed15.TabIndex = 32
			Me.PscLed15.toolTip = Nothing
			'
			'PscLed16
			'
			Me.PscLed16.CausesValidation = False
			Me.PscLed16.ledBackTransparent = False
			Me.PscLed16.ledBeep = ledAudio.audioOff
			Me.PscLed16.ledBlinkSpeed = blinkSpeed.blinkFast
			Me.PscLed16.ledBorder = ledBorderStyle.None
			Me.PscLed16.ledColor = mainColor.colorGreen
			Me.PscLed16.ledColorBlink = blinkColor.colorDark
			Me.PscLed16.ledDesignBehaviour = ledDesignMode.blinkOn_audioOff
			Me.PscLed16.ledFlashNext = Nothing
			Me.PscLed16.ledNextTrigger = ledTrigger.nextDelay
			Me.PscLed16.ledSize = ledModel.sizeSmall
			Me.PscLed16.ledSoundFile = ""
			Me.PscLed16.ledStatus = ledModus.ledOff
			Me.PscLed16.Location = New System.Drawing.Point(626, 62)
			Me.PscLed16.Name = "PscLed16"
			Me.PscLed16.Size = New System.Drawing.Size(16, 16)
			Me.PscLed16.socketColor = System.Drawing.KnownColor.Silver
			Me.PscLed16.socketFeature = ledSocketFeature.sockedDeepened
			Me.PscLed16.socketWidth = ledSocketWidth.widthMedium
			Me.PscLed16.TabIndex = 31
			Me.PscLed16.toolTip = Nothing
			'
			'PscLed17
			'
			Me.PscLed17.CausesValidation = False
			Me.PscLed17.ledBackTransparent = False
			Me.PscLed17.ledBeep = ledAudio.audioOff
			Me.PscLed17.ledBlinkSpeed = blinkSpeed.blinkFast
			Me.PscLed17.ledBorder = ledBorderStyle.None
			Me.PscLed17.ledColor = mainColor.colorRed
			Me.PscLed17.ledColorBlink = blinkColor.colorDark
			Me.PscLed17.ledDesignBehaviour = ledDesignMode.blinkOn_audioOff
			Me.PscLed17.ledFlashNext = Nothing
			Me.PscLed17.ledNextTrigger = ledTrigger.nextDelay
			Me.PscLed17.ledSize = ledModel.sizeSmall
			Me.PscLed17.ledSoundFile = ""
			Me.PscLed17.ledStatus = ledModus.ledOn
			Me.PscLed17.Location = New System.Drawing.Point(626, 16)
			Me.PscLed17.Name = "PscLed17"
			Me.PscLed17.Size = New System.Drawing.Size(16, 16)
			Me.PscLed17.socketColor = System.Drawing.KnownColor.Silver
			Me.PscLed17.socketFeature = ledSocketFeature.sockedDeepened
			Me.PscLed17.socketWidth = ledSocketWidth.widthMedium
			Me.PscLed17.TabIndex = 30
			Me.PscLed17.toolTip = Nothing
			'
			'frmLedDemo
			'
			Me.AutoScaleBaseSize = New System.Drawing.Size(6, 13)
			Me.CancelButton = Me.cmdEnd
			Me.ClientSize = New System.Drawing.Size(662, 405)
			Me.Controls.Add(Me.PscLed10)
			Me.Controls.Add(Me.PscLed11)
			Me.Controls.Add(Me.PscLed12)
			Me.Controls.Add(Me.PscLed13)
			Me.Controls.Add(Me.PscLed14)
			Me.Controls.Add(Me.PscLed15)
			Me.Controls.Add(Me.PscLed16)
			Me.Controls.Add(Me.PscLed17)
			Me.Controls.Add(Me.PscLed6)
			Me.Controls.Add(Me.PscLed7)
			Me.Controls.Add(Me.PscLed8)
			Me.Controls.Add(Me.PscLed9)
			Me.Controls.Add(Me.PscLed4)
			Me.Controls.Add(Me.PscLed5)
			Me.Controls.Add(Me.PscLed3)
			Me.Controls.Add(Me.PscLed2)
			Me.Controls.Add(Me.cmdEnd)
			Me.Controls.Add(Me.GroupBox1)
			Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
			Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
			Me.Name = "frmLedDemo"
			Me.Text = "pscLed Demo"
			Me.GroupBox1.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

#End Region
		Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
			Dim i As Integer
			fillCombo(cbBeep, New ledAudio)
			fillCombo(cbColor, New mainColor)
			fillCombo(cbStatus, New ledModus)
			fillCombo(cbSize, New ledModel)
			fillCombo(cbBlink, New blinkColor)
			fillCombo(cbSpeed, New blinkSpeed)
			fillCombo(cbBorder, New ledBorderStyle)
			fillCombo(cbSockWidth, New ledSocketWidth)
			fillColorCombo(cbSockColor, New System.Drawing.KnownColor, True)
			fillColorCombo(cbBackColor, New System.Drawing.KnownColor, False)
			fillCombo(cbFeature, New ledSocketFeature)
			fillCombo(cbSound, ".wav")
			For i = 0 To cbBackColor.Items.Count - 1
				If cbBackColor.Items(i).ToString = PscLed1.BackColor.Name Then
					cbBackColor.SelectedIndex = i
				End If
			Next
			cbSockColor.SelectedItem = PscLed1.socketColor
			cbBlink.SelectedItem = "colorDark"
			cbSpeed.SelectedItem = "blinkMedium"
			cbSize.SelectedItem = "sizeMaxi"
			cbStatus.SelectedItem = "ledBlink"
			cbColor.SelectedItem = "colorGreen"
			PscLed1.toolTip = txtTooltip.Text
			PscLed1.ledStatus = ledModus.ledBlink
			PscLed1.Select()
			PscLed2.ledFlashNext = "PscLed3"
			PscLed3.ledFlashNext = "PscLed4"
			PscLed4.ledFlashNext = "PscLed5"
			PscLed5.ledFlashNext = "PscLed6"
			PscLed6.ledFlashNext = "PscLed7"
			PscLed7.ledFlashNext = "PscLed8"
			PscLed8.ledFlashNext = "PscLed9"
			PscLed9.ledFlashNext = "PscLed2"
			PscLed10.ledFlashNext = "PscLed17"
			PscLed11.ledFlashNext = "PscLed10"
			PscLed12.ledFlashNext = "PscLed11"
			PscLed13.ledFlashNext = "PscLed12"
			PscLed14.ledFlashNext = "PscLed13"
			PscLed15.ledFlashNext = "PscLed14"
			PscLed16.ledFlashNext = "PscLed15"
			PscLed17.ledFlashNext = "PscLed16"

			Dim a$
			a$ = "This chain is programmed like this:"
			a$ = a$ & vbCrLf & "At program start the first LED is 'Flashed'"
			a$ = a$ & vbCrLf & "When it is switched off, is 'flashes' the next LED etc."
			a$ = a$ & vbCrLf & "The next LED is defined by setting the 'ledFlashNext' property"
			a$ = a$ & vbCrLf & "While the right row starts with 'nextDelay', starts the left row with 'nextDirect'"
			PscLed9.toolTip = a$
			PscLed10.toolTip = a$
			PscLed11.toolTip = a$
			PscLed12.toolTip = a$
			PscLed13.toolTip = a$
			PscLed14.toolTip = a$
			PscLed15.toolTip = a$
			PscLed16.toolTip = a$
			PscLed17.toolTip = a$
			PscLed8.toolTip = a$
			PscLed9.toolTip = a$
			PscLed6.toolTip = a$
			PscLed5.toolTip = a$
			PscLed2.toolTip = a$
			PscLed3.toolTip = a$
			PscLed4.toolTip = a$
		End Sub
		Private Sub fillColorCombo(ByRef cb As Windows.Forms.ComboBox, ByRef test As Object, ByVal isKnown As Boolean)
			Dim i As Integer
			Dim von As Integer
			Dim bis As Integer
			cb.Items.Clear()
			Dim items() As System.Drawing.KnownColor = System.Enum.GetValues(test.GetType)
			If isKnown Then
				von = CInt(System.Drawing.KnownColor.AliceBlue) - 1
				bis = UBound(items)
			Else
				von = 0
				bis = CInt(System.Drawing.KnownColor.AliceBlue) - 2
			End If
			For i = von To bis
				cb.Items.Add(items(i))
			Next
		End Sub
		Private Sub fillCombo(ByRef cb As Windows.Forms.ComboBox, ByRef test As Object)
			Dim i As Integer
			Dim tp As System.Type = test.GetType()
			If (tp.FullName.Equals("System.String")) Then
				Dim N() As String = [Assembly].GetExecutingAssembly().GetManifestResourceNames
				Dim a As String
				cb.Items.Clear()
				Dim x() As String
				For i = 0 To UBound(N)
					If N(i).EndsWith(test) Then
						x = Split(N(i), ".")
						a = x(UBound(x) - 1) & "." & x(UBound(x))
						cb.Items.Add(a)
					End If
				Next i
			Else
				cb.Items.Clear()
				Dim items() As String = System.Enum.GetNames(test.GetType)
				For i = 0 To UBound(items)
					cb.Items.Add(items(i))
				Next
			End If
			If cb.Items.Count > 0 Then cb.SelectedIndex = 0
		End Sub
		Private Sub cbSize_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbSize.SelectedIndexChanged
			PscLed1.ledSize = CType(sender, Windows.Forms.ComboBox).SelectedIndex
		End Sub

		Private Sub cbColor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbColor.SelectedIndexChanged
			PscLed1.ledColor = CType(sender, Windows.Forms.ComboBox).SelectedIndex
		End Sub

		Private Sub cbStatus_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbStatus.SelectedIndexChanged
			PscLed1.ledStatus = CType(sender, Windows.Forms.ComboBox).SelectedIndex
		End Sub

		Private Sub cbBlink_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbBlink.SelectedIndexChanged
			PscLed1.ledColorBlink = CType(sender, Windows.Forms.ComboBox).SelectedIndex
		End Sub

		Private Sub cbSpeed_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbSpeed.SelectedIndexChanged
			PscLed1.ledBlinkSpeed = CType(sender, Windows.Forms.ComboBox).SelectedIndex
		End Sub

		Private Sub cbBeep_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbBeep.SelectedIndexChanged
			PscLed1.ledBeep = CType(sender, Windows.Forms.ComboBox).SelectedIndex
		End Sub

		Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEnd.Click
			End
		End Sub

		Private Sub Form1_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
			If PscLed2.ledStatus = ledModus.ledOn Then
				PscLed2.ledStatus = ledModus.ledFlash
				PscLed17.ledStatus = ledModus.ledFlash
			End If
		End Sub

		Private Sub cbSound_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbSound.SelectedIndexChanged
			Dim a As String = [Assembly].GetExecutingAssembly().GetName().Name
			PscLed1.ledSoundFile = a & "." & CStr(CType(sender, Windows.Forms.ComboBox).SelectedItem)
		End Sub

		Private Sub txtTooltip_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTooltip.TextChanged
			PscLed1.toolTip = txtTooltip.Text
		End Sub

		Private Sub cbBorder_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbBorder.SelectedIndexChanged
			PscLed1.ledBorder = CType(sender, Windows.Forms.ComboBox).SelectedIndex
		End Sub

		Private Sub cbBack_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
			PscLed1.BackColor = CType(sender, Windows.Forms.ComboBox).SelectedItem
		End Sub

		Private Sub cbSockWidth_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbSockWidth.SelectedIndexChanged
			PscLed1.socketWidth = CType(sender, Windows.Forms.ComboBox).SelectedIndex
		End Sub

		Private Sub cbSockColor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbSockColor.SelectedIndexChanged
			PscLed1.socketColor = CType(sender, Windows.Forms.ComboBox).SelectedItem
		End Sub

		Private Sub cbFeature_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbFeature.SelectedIndexChanged
			PscLed1.socketFeature = CType(sender, Windows.Forms.ComboBox).SelectedIndex
		End Sub

		Private Sub cbBackColor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbBackColor.SelectedIndexChanged
			If CType(sender, Windows.Forms.ComboBox).SelectedItem.Equals(System.Drawing.KnownColor.Transparent) Then
				PscLed1.ledBackTransparent = True
			Else
				PscLed1.ledBackTransparent = False
				PscLed1.BackColor = Color.FromKnownColor(CType(sender, Windows.Forms.ComboBox).SelectedItem)
			End If
		End Sub
	End Class
End Namespace