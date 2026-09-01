<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBlocNotas
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBlocNotas))
        MnuPrincipal = New MenuStrip()
        ArchivoToolStripMenuItem = New ToolStripMenuItem()
        mnuNuevo = New ToolStripMenuItem()
        mnuAbrir = New ToolStripMenuItem()
        mnuGuardar = New ToolStripMenuItem()
        mnuGuardarComo = New ToolStripMenuItem()
        mnuSalir = New ToolStripMenuItem()
        FormatoToolStripMenuItem = New ToolStripMenuItem()
        mnuFuente = New ToolStripMenuItem()
        mnuAjusteLinea = New ToolStripMenuItem()
        EdicionToolStripMenuItem = New ToolStripMenuItem()
        mnuCortar = New ToolStripMenuItem()
        mnuCopiar = New ToolStripMenuItem()
        mnuPegar = New ToolStripMenuItem()
        AyudaToolStripMenuItem = New ToolStripMenuItem()
        tsPrincipal = New ToolStrip()
        rtbDocumento = New RichTextBox()
        cmsTexto = New ContextMenuStrip(components)
        CortarToolStripMenuItem = New ToolStripMenuItem()
        PegarToolStripMenuItem = New ToolStripMenuItem()
        CopiarToolStripMenuItem = New ToolStripMenuItem()
        SelecionarTodoToolStripMenuItem = New ToolStripMenuItem()
        FuentesToolStripMenuItem = New ToolStripMenuItem()
        stsInferior = New StatusStrip()
        dlgAbrir = New OpenFileDialog()
        dlgGuardar = New SaveFileDialog()
        dlgFuentes = New FontDialog()
        dlgColor = New ColorDialog()
        tmrReloj = New Timer(components)
        ToolStripButton1 = New ToolStripButton()
        ToolStripButton2 = New ToolStripButton()
        ToolStripButton3 = New ToolStripButton()
        ToolStripButton4 = New ToolStripButton()
        MnuPrincipal.SuspendLayout()
        tsPrincipal.SuspendLayout()
        cmsTexto.SuspendLayout()
        SuspendLayout()
        ' 
        ' MnuPrincipal
        ' 
        MnuPrincipal.ImageScalingSize = New Size(20, 20)
        MnuPrincipal.Items.AddRange(New ToolStripItem() {ArchivoToolStripMenuItem, FormatoToolStripMenuItem, EdicionToolStripMenuItem, AyudaToolStripMenuItem})
        MnuPrincipal.Location = New Point(0, 0)
        MnuPrincipal.Name = "MnuPrincipal"
        MnuPrincipal.Padding = New Padding(8, 2, 0, 2)
        MnuPrincipal.Size = New Size(1000, 33)
        MnuPrincipal.TabIndex = 0
        MnuPrincipal.Text = "MenuStrip1"
        ' 
        ' ArchivoToolStripMenuItem
        ' 
        ArchivoToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {mnuNuevo, mnuAbrir, mnuGuardar, mnuGuardarComo, mnuSalir})
        ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        ArchivoToolStripMenuItem.Size = New Size(88, 29)
        ArchivoToolStripMenuItem.Text = "Archivo"
        ' 
        ' mnuNuevo
        ' 
        mnuNuevo.Name = "mnuNuevo"
        mnuNuevo.ShortcutKeys = Keys.Control Or Keys.N
        mnuNuevo.Size = New Size(240, 34)
        mnuNuevo.Text = "&Nuevo"
        ' 
        ' mnuAbrir
        ' 
        mnuAbrir.Name = "mnuAbrir"
        mnuAbrir.ShortcutKeys = Keys.Control Or Keys.O
        mnuAbrir.Size = New Size(240, 34)
        mnuAbrir.Text = "&Abrir"
        ' 
        ' mnuGuardar
        ' 
        mnuGuardar.Name = "mnuGuardar"
        mnuGuardar.ShortcutKeys = Keys.Control Or Keys.S
        mnuGuardar.Size = New Size(240, 34)
        mnuGuardar.Text = "&Guardar"
        ' 
        ' mnuGuardarComo
        ' 
        mnuGuardarComo.Name = "mnuGuardarComo"
        mnuGuardarComo.Size = New Size(240, 34)
        mnuGuardarComo.Text = "Guardar &como..."
        ' 
        ' mnuSalir
        ' 
        mnuSalir.Name = "mnuSalir"
        mnuSalir.ShortcutKeys = Keys.Alt Or Keys.F4
        mnuSalir.Size = New Size(240, 34)
        mnuSalir.Text = "&Salir"
        ' 
        ' FormatoToolStripMenuItem
        ' 
        FormatoToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {mnuFuente, mnuAjusteLinea})
        FormatoToolStripMenuItem.Name = "FormatoToolStripMenuItem"
        FormatoToolStripMenuItem.Size = New Size(96, 29)
        FormatoToolStripMenuItem.Text = "Formato"
        ' 
        ' mnuFuente
        ' 
        mnuFuente.Name = "mnuFuente"
        mnuFuente.Size = New Size(270, 34)
        mnuFuente.Text = "&Fuente..."
        ' 
        ' mnuAjusteLinea
        ' 
        mnuAjusteLinea.CheckOnClick = True
        mnuAjusteLinea.Name = "mnuAjusteLinea"
        mnuAjusteLinea.Size = New Size(270, 34)
        mnuAjusteLinea.Text = "Ajuste de línea"
        ' 
        ' EdicionToolStripMenuItem
        ' 
        EdicionToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {mnuCortar, mnuCopiar, mnuPegar})
        EdicionToolStripMenuItem.Name = "EdicionToolStripMenuItem"
        EdicionToolStripMenuItem.Size = New Size(85, 29)
        EdicionToolStripMenuItem.Text = "Edicion"
        ' 
        ' mnuCortar
        ' 
        mnuCortar.Name = "mnuCortar"
        mnuCortar.ShortcutKeys = Keys.Control Or Keys.X
        mnuCortar.Size = New Size(228, 34)
        mnuCortar.Text = "Cortar"
        ' 
        ' mnuCopiar
        ' 
        mnuCopiar.Name = "mnuCopiar"
        mnuCopiar.ShortcutKeys = Keys.Control Or Keys.X
        mnuCopiar.Size = New Size(228, 34)
        mnuCopiar.Text = "Copiar"
        ' 
        ' mnuPegar
        ' 
        mnuPegar.Name = "mnuPegar"
        mnuPegar.ShortcutKeys = Keys.Control Or Keys.X
        mnuPegar.Size = New Size(228, 34)
        mnuPegar.Text = "Pegar"
        ' 
        ' AyudaToolStripMenuItem
        ' 
        AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        AyudaToolStripMenuItem.Size = New Size(79, 29)
        AyudaToolStripMenuItem.Text = "Ayuda"
        ' 
        ' tsPrincipal
        ' 
        tsPrincipal.GripStyle = ToolStripGripStyle.Hidden
        tsPrincipal.ImageScalingSize = New Size(20, 20)
        tsPrincipal.Items.AddRange(New ToolStripItem() {ToolStripButton1, ToolStripButton2, ToolStripButton3, ToolStripButton4})
        tsPrincipal.Location = New Point(0, 33)
        tsPrincipal.Name = "tsPrincipal"
        tsPrincipal.Size = New Size(1000, 34)
        tsPrincipal.TabIndex = 1
        tsPrincipal.Text = "ToolStrip1"
        ' 
        ' rtbDocumento
        ' 
        rtbDocumento.ContextMenuStrip = cmsTexto
        rtbDocumento.Dock = DockStyle.Fill
        rtbDocumento.Font = New Font("Consolas", 11F)
        rtbDocumento.Location = New Point(0, 67)
        rtbDocumento.Margin = New Padding(4, 4, 4, 4)
        rtbDocumento.Name = "rtbDocumento"
        rtbDocumento.Size = New Size(1000, 495)
        rtbDocumento.TabIndex = 2
        rtbDocumento.Text = ""
        ' 
        ' cmsTexto
        ' 
        cmsTexto.ImageScalingSize = New Size(20, 20)
        cmsTexto.Items.AddRange(New ToolStripItem() {CortarToolStripMenuItem, PegarToolStripMenuItem, CopiarToolStripMenuItem, SelecionarTodoToolStripMenuItem, FuentesToolStripMenuItem})
        cmsTexto.Name = "cmsTexto"
        cmsTexto.Size = New Size(210, 164)
        ' 
        ' CortarToolStripMenuItem
        ' 
        CortarToolStripMenuItem.Name = "CortarToolStripMenuItem"
        CortarToolStripMenuItem.Size = New Size(209, 32)
        CortarToolStripMenuItem.Text = "Cortar"
        ' 
        ' PegarToolStripMenuItem
        ' 
        PegarToolStripMenuItem.Name = "PegarToolStripMenuItem"
        PegarToolStripMenuItem.Size = New Size(209, 32)
        PegarToolStripMenuItem.Text = "Pegar"
        ' 
        ' CopiarToolStripMenuItem
        ' 
        CopiarToolStripMenuItem.Name = "CopiarToolStripMenuItem"
        CopiarToolStripMenuItem.Size = New Size(209, 32)
        CopiarToolStripMenuItem.Text = "Copiar"
        ' 
        ' SelecionarTodoToolStripMenuItem
        ' 
        SelecionarTodoToolStripMenuItem.Name = "SelecionarTodoToolStripMenuItem"
        SelecionarTodoToolStripMenuItem.Size = New Size(209, 32)
        SelecionarTodoToolStripMenuItem.Text = "Selecionar Todo"
        ' 
        ' FuentesToolStripMenuItem
        ' 
        FuentesToolStripMenuItem.Name = "FuentesToolStripMenuItem"
        FuentesToolStripMenuItem.Size = New Size(209, 32)
        FuentesToolStripMenuItem.Text = "Fuentes"
        ' 
        ' stsInferior
        ' 
        stsInferior.ImageScalingSize = New Size(20, 20)
        stsInferior.Location = New Point(0, 540)
        stsInferior.Name = "stsInferior"
        stsInferior.Padding = New Padding(1, 0, 18, 0)
        stsInferior.Size = New Size(1000, 22)
        stsInferior.TabIndex = 4
        stsInferior.Text = "StatusStrip1"
        ' 
        ' dlgAbrir
        ' 
        dlgAbrir.FileName = "OpenFileDialog1"
        dlgAbrir.Filter = "Archivos de texto (*.txt)|*.txt|Todos (*.*)|*.*"
        ' 
        ' dlgGuardar
        ' 
        dlgGuardar.DefaultExt = "txt"
        ' 
        ' dlgFuentes
        ' 
        dlgFuentes.ShowColor = True
        ' 
        ' dlgColor
        ' 
        dlgColor.FullOpen = True
        ' 
        ' tmrReloj
        ' 
        tmrReloj.Enabled = True
        tmrReloj.Interval = 1000
        ' 
        ' ToolStripButton1
        ' 
        ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), Image)
        ToolStripButton1.ImageTransparentColor = Color.Magenta
        ToolStripButton1.Name = "ToolStripButton1"
        ToolStripButton1.Size = New Size(168, 29)
        ToolStripButton1.Text = "ToolStripButton1"
        ' 
        ' ToolStripButton2
        ' 
        ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), Image)
        ToolStripButton2.ImageTransparentColor = Color.Magenta
        ToolStripButton2.Name = "ToolStripButton2"
        ToolStripButton2.Size = New Size(168, 29)
        ToolStripButton2.Text = "ToolStripButton2"
        ' 
        ' ToolStripButton3
        ' 
        ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), Image)
        ToolStripButton3.ImageTransparentColor = Color.Magenta
        ToolStripButton3.Name = "ToolStripButton3"
        ToolStripButton3.Size = New Size(168, 29)
        ToolStripButton3.Text = "ToolStripButton3"
        ' 
        ' ToolStripButton4
        ' 
        ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), Image)
        ToolStripButton4.ImageTransparentColor = Color.Magenta
        ToolStripButton4.Name = "ToolStripButton4"
        ToolStripButton4.Size = New Size(168, 29)
        ToolStripButton4.Text = "ToolStripButton4"
        ' 
        ' frmBlocNotas
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1000, 562)
        Controls.Add(stsInferior)
        Controls.Add(rtbDocumento)
        Controls.Add(tsPrincipal)
        Controls.Add(MnuPrincipal)
        MainMenuStrip = MnuPrincipal
        Margin = New Padding(4, 4, 4, 4)
        MinimumSize = New Size(744, 486)
        Name = "frmBlocNotas"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Bloc de Notas VB.NET"
        MnuPrincipal.ResumeLayout(False)
        MnuPrincipal.PerformLayout()
        tsPrincipal.ResumeLayout(False)
        tsPrincipal.PerformLayout()
        cmsTexto.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MnuPrincipal As MenuStrip
    Friend WithEvents tsPrincipal As ToolStrip
    Friend WithEvents rtbDocumento As RichTextBox
    Friend WithEvents cmsTexto As ContextMenuStrip
    Friend WithEvents stsInferior As StatusStrip
    Friend WithEvents dlgAbrir As OpenFileDialog
    Friend WithEvents dlgGuardar As SaveFileDialog
    Friend WithEvents CortarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PegarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopiarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SelecionarTodoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FuentesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents dlgFuentes As FontDialog
    Friend WithEvents dlgColor As ColorDialog
    Friend WithEvents tmrReloj As Timer
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FormatoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EdicionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuNuevo As ToolStripMenuItem
    Friend WithEvents mnuAbrir As ToolStripMenuItem
    Friend WithEvents mnuGuardar As ToolStripMenuItem
    Friend WithEvents mnuGuardarComo As ToolStripMenuItem
    Friend WithEvents mnuSalir As ToolStripMenuItem
    Friend WithEvents mnuFuente As ToolStripMenuItem
    Friend WithEvents mnuAjusteLinea As ToolStripMenuItem
    Friend WithEvents mnuCortar As ToolStripMenuItem
    Friend WithEvents mnuCopiar As ToolStripMenuItem
    Friend WithEvents mnuPegar As ToolStripMenuItem
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents ToolStripButton4 As ToolStripButton

End Class
