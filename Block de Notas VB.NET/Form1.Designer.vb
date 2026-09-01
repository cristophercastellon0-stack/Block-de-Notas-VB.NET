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
        MnuPrincipal = New MenuStrip()
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
        AyudaToolStripMenuItem = New ToolStripMenuItem()
        EdicionToolStripMenuItem = New ToolStripMenuItem()
        FormatoToolStripMenuItem = New ToolStripMenuItem()
        ArchivoToolStripMenuItem = New ToolStripMenuItem()
        mnuNuevo = New ToolStripMenuItem()
        mnuAbrir = New ToolStripMenuItem()
        mnuGuardar = New ToolStripMenuItem()
        mnuGuardarComo = New ToolStripMenuItem()
        mnuSalir = New ToolStripMenuItem()
        mnuCortar = New ToolStripMenuItem()
        mnuCopiar = New ToolStripMenuItem()
        mnuPegar = New ToolStripMenuItem()
        mnuFuente = New ToolStripMenuItem()
        mnuAjusteLinea = New ToolStripMenuItem()
        MnuPrincipal.SuspendLayout()
        cmsTexto.SuspendLayout()
        SuspendLayout()
        ' 
        ' MnuPrincipal
        ' 
        MnuPrincipal.ImageScalingSize = New Size(20, 20)
        MnuPrincipal.Items.AddRange(New ToolStripItem() {ArchivoToolStripMenuItem, FormatoToolStripMenuItem, EdicionToolStripMenuItem, AyudaToolStripMenuItem})
        MnuPrincipal.Location = New Point(0, 0)
        MnuPrincipal.Name = "MnuPrincipal"
        MnuPrincipal.Size = New Size(800, 28)
        MnuPrincipal.TabIndex = 0
        MnuPrincipal.Text = "MenuStrip1"
        ' 
        ' tsPrincipal
        ' 
        tsPrincipal.GripStyle = ToolStripGripStyle.Hidden
        tsPrincipal.ImageScalingSize = New Size(20, 20)
        tsPrincipal.Location = New Point(0, 28)
        tsPrincipal.Name = "tsPrincipal"
        tsPrincipal.Size = New Size(800, 25)
        tsPrincipal.TabIndex = 1
        tsPrincipal.Text = "ToolStrip1"
        ' 
        ' rtbDocumento
        ' 
        rtbDocumento.ContextMenuStrip = cmsTexto
        rtbDocumento.Dock = DockStyle.Fill
        rtbDocumento.Font = New Font("Consolas", 11F)
        rtbDocumento.Location = New Point(0, 53)
        rtbDocumento.Name = "rtbDocumento"
        rtbDocumento.Size = New Size(800, 397)
        rtbDocumento.TabIndex = 2
        rtbDocumento.Text = ""
        ' 
        ' cmsTexto
        ' 
        cmsTexto.ImageScalingSize = New Size(20, 20)
        cmsTexto.Items.AddRange(New ToolStripItem() {CortarToolStripMenuItem, PegarToolStripMenuItem, CopiarToolStripMenuItem, SelecionarTodoToolStripMenuItem, FuentesToolStripMenuItem})
        cmsTexto.Name = "cmsTexto"
        cmsTexto.Size = New Size(186, 124)
        ' 
        ' CortarToolStripMenuItem
        ' 
        CortarToolStripMenuItem.Name = "CortarToolStripMenuItem"
        CortarToolStripMenuItem.Size = New Size(185, 24)
        CortarToolStripMenuItem.Text = "Cortar"
        ' 
        ' PegarToolStripMenuItem
        ' 
        PegarToolStripMenuItem.Name = "PegarToolStripMenuItem"
        PegarToolStripMenuItem.Size = New Size(185, 24)
        PegarToolStripMenuItem.Text = "Pegar"
        ' 
        ' CopiarToolStripMenuItem
        ' 
        CopiarToolStripMenuItem.Name = "CopiarToolStripMenuItem"
        CopiarToolStripMenuItem.Size = New Size(185, 24)
        CopiarToolStripMenuItem.Text = "Copiar"
        ' 
        ' SelecionarTodoToolStripMenuItem
        ' 
        SelecionarTodoToolStripMenuItem.Name = "SelecionarTodoToolStripMenuItem"
        SelecionarTodoToolStripMenuItem.Size = New Size(185, 24)
        SelecionarTodoToolStripMenuItem.Text = "Selecionar Todo"
        ' 
        ' FuentesToolStripMenuItem
        ' 
        FuentesToolStripMenuItem.Name = "FuentesToolStripMenuItem"
        FuentesToolStripMenuItem.Size = New Size(185, 24)
        FuentesToolStripMenuItem.Text = "Fuentes"
        ' 
        ' stsInferior
        ' 
        stsInferior.ImageScalingSize = New Size(20, 20)
        stsInferior.Location = New Point(0, 428)
        stsInferior.Name = "stsInferior"
        stsInferior.Size = New Size(800, 22)
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
        ' AyudaToolStripMenuItem
        ' 
        AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        AyudaToolStripMenuItem.Size = New Size(65, 24)
        AyudaToolStripMenuItem.Text = "Ayuda"
        ' 
        ' EdicionToolStripMenuItem
        ' 
        EdicionToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {mnuCortar, mnuCopiar, mnuPegar})
        EdicionToolStripMenuItem.Name = "EdicionToolStripMenuItem"
        EdicionToolStripMenuItem.Size = New Size(72, 24)
        EdicionToolStripMenuItem.Text = "Edicion"
        ' 
        ' FormatoToolStripMenuItem
        ' 
        FormatoToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {mnuFuente, mnuAjusteLinea})
        FormatoToolStripMenuItem.Name = "FormatoToolStripMenuItem"
        FormatoToolStripMenuItem.Size = New Size(79, 24)
        FormatoToolStripMenuItem.Text = "Formato"
        ' 
        ' ArchivoToolStripMenuItem
        ' 
        ArchivoToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {mnuNuevo, mnuAbrir, mnuGuardar, mnuGuardarComo, mnuSalir})
        ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        ArchivoToolStripMenuItem.Size = New Size(73, 24)
        ArchivoToolStripMenuItem.Text = "Archivo"
        ' 
        ' mnuNuevo
        ' 
        mnuNuevo.Name = "mnuNuevo"
        mnuNuevo.ShortcutKeys = Keys.Control Or Keys.N
        mnuNuevo.Size = New Size(224, 26)
        mnuNuevo.Text = "&Nuevo"
        ' 
        ' mnuAbrir
        ' 
        mnuAbrir.Name = "mnuAbrir"
        mnuAbrir.ShortcutKeys = Keys.Control Or Keys.O
        mnuAbrir.Size = New Size(224, 26)
        mnuAbrir.Text = "&Abrir"
        ' 
        ' mnuGuardar
        ' 
        mnuGuardar.Name = "mnuGuardar"
        mnuGuardar.ShortcutKeys = Keys.Control Or Keys.S
        mnuGuardar.Size = New Size(224, 26)
        mnuGuardar.Text = "&Guardar"
        ' 
        ' mnuGuardarComo
        ' 
        mnuGuardarComo.Name = "mnuGuardarComo"
        mnuGuardarComo.Size = New Size(224, 26)
        mnuGuardarComo.Text = "Guardar &como..."
        ' 
        ' mnuSalir
        ' 
        mnuSalir.Name = "mnuSalir"
        mnuSalir.ShortcutKeys = Keys.Alt Or Keys.F4
        mnuSalir.Size = New Size(224, 26)
        mnuSalir.Text = "&Salir"
        ' 
        ' mnuCortar
        ' 
        mnuCortar.Name = "mnuCortar"
        mnuCortar.ShortcutKeys = Keys.Control Or Keys.X
        mnuCortar.Size = New Size(224, 26)
        mnuCortar.Text = "Cortar"
        ' 
        ' mnuCopiar
        ' 
        mnuCopiar.Name = "mnuCopiar"
        mnuCopiar.ShortcutKeys = Keys.Control Or Keys.X
        mnuCopiar.Size = New Size(224, 26)
        mnuCopiar.Text = "Copiar"
        ' 
        ' mnuPegar
        ' 
        mnuPegar.Name = "mnuPegar"
        mnuPegar.ShortcutKeys = Keys.Control Or Keys.X
        mnuPegar.Size = New Size(224, 26)
        mnuPegar.Text = "Pegar"
        ' 
        ' mnuFuente
        ' 
        mnuFuente.Name = "mnuFuente"
        mnuFuente.Size = New Size(224, 26)
        mnuFuente.Text = "&Fuente..."
        ' 
        ' mnuAjusteLinea
        ' 
        mnuAjusteLinea.CheckOnClick = True
        mnuAjusteLinea.Name = "mnuAjusteLinea"
        mnuAjusteLinea.Size = New Size(224, 26)
        mnuAjusteLinea.Text = "Ajuste de línea"
        ' 
        ' frmBlocNotas
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(stsInferior)
        Controls.Add(rtbDocumento)
        Controls.Add(tsPrincipal)
        Controls.Add(MnuPrincipal)
        MainMenuStrip = MnuPrincipal
        MinimumSize = New Size(600, 400)
        Name = "frmBlocNotas"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Bloc de Notas VB.NET"
        MnuPrincipal.ResumeLayout(False)
        MnuPrincipal.PerformLayout()
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

End Class
