<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DefMessaggi
    Inherits FunzioniIntegra.BaseForm

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla nell'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Overloads Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DefMessaggi))
        Dim Style1 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style
        Dim Style2 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style
        Dim Style3 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style
        Dim Style4 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style
        Dim Style5 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style
        Dim Style6 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style
        Dim Style7 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style
        Dim Style8 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style
        Dim Style9 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style
        Dim Style10 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style
        Dim Style11 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style
        Dim Style12 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style
        Dim Style13 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style
        Dim Style14 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style
        Dim Style15 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style
        Dim Style16 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.BtnFirst = New System.Windows.Forms.ToolStripButton
        Me.BtnPrev = New System.Windows.Forms.ToolStripButton
        Me.BtnAdd = New System.Windows.Forms.ToolStripButton
        Me.BtnDel = New System.Windows.Forms.ToolStripButton
        Me.BtnNext = New System.Windows.Forms.ToolStripButton
        Me.BtnLast = New System.Windows.Forms.ToolStripButton
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.GridDef = New FlexGroup.C1TrueDBGridIntegra
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.ChkGridLocked = New System.Windows.Forms.CheckBox
        Me.GroupFilter = New System.Windows.Forms.GroupBox
        Me.TxtFilterNumSubCampo = New FunzioniIntegra.TextBoxIntegra
        Me.TxtFilterNumCampo = New FunzioniIntegra.TextBoxIntegra
        Me.TxtFilterDescrizione = New FunzioniIntegra.TextBoxIntegra
        Me.BtnCancelFilter = New System.Windows.Forms.Button
        Me.BtnApplyFilter = New System.Windows.Forms.Button
        Me.LblNumSubCampo = New System.Windows.Forms.Label
        Me.LblFilterDescrizione = New System.Windows.Forms.Label
        Me.LblNumCampo = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.CmbTipoMsg = New FlexGroup.C1ComboBoxIntegraV2
        Me.DropObbligatorieta = New C1.Win.C1TrueDBGrid.C1TrueDBDropdown
        Me.DropFormatoTipo = New C1.Win.C1TrueDBGrid.C1TrueDBDropdown
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.GridDef, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupFilter.SuspendLayout()
        CType(Me.CmbTipoMsg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DropObbligatorieta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DropFormatoTipo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusBar1
        '
        Me.StatusBar1.Location = New System.Drawing.Point(0, 525)
        Me.StatusBar1.Size = New System.Drawing.Size(804, 22)
        '
        'StatusBarPanel1
        '
        Me.StatusBarPanel1.Width = 398
        '
        'StatusBarPanel3
        '
        Me.StatusBarPanel3.Text = "NUM"
        '
        'StatusBarPanel6
        '
        Me.StatusBarPanel6.Text = "30/12/2010 02.07.32"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnFirst, Me.BtnPrev, Me.BtnAdd, Me.BtnDel, Me.BtnNext, Me.BtnLast, Me.toolStripSeparator1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(804, 25)
        Me.ToolStrip1.TabIndex = 4
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'BtnFirst
        '
        Me.BtnFirst.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnFirst.Image = CType(resources.GetObject("BtnFirst.Image"), System.Drawing.Image)
        Me.BtnFirst.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnFirst.Name = "BtnFirst"
        Me.BtnFirst.Size = New System.Drawing.Size(23, 22)
        Me.BtnFirst.Text = "Prima"
        '
        'BtnPrev
        '
        Me.BtnPrev.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnPrev.Image = CType(resources.GetObject("BtnPrev.Image"), System.Drawing.Image)
        Me.BtnPrev.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnPrev.Name = "BtnPrev"
        Me.BtnPrev.Size = New System.Drawing.Size(23, 22)
        Me.BtnPrev.Text = "Precedente"
        '
        'BtnAdd
        '
        Me.BtnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnAdd.Image = CType(resources.GetObject("BtnAdd.Image"), System.Drawing.Image)
        Me.BtnAdd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(23, 22)
        '
        'BtnDel
        '
        Me.BtnDel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnDel.Image = CType(resources.GetObject("BtnDel.Image"), System.Drawing.Image)
        Me.BtnDel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnDel.Name = "BtnDel"
        Me.BtnDel.Size = New System.Drawing.Size(23, 22)
        Me.BtnDel.Text = "Elimina"
        '
        'BtnNext
        '
        Me.BtnNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnNext.Image = CType(resources.GetObject("BtnNext.Image"), System.Drawing.Image)
        Me.BtnNext.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnNext.Name = "BtnNext"
        Me.BtnNext.Size = New System.Drawing.Size(23, 22)
        Me.BtnNext.Text = "Successiva"
        '
        'BtnLast
        '
        Me.BtnLast.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnLast.Image = CType(resources.GetObject("BtnLast.Image"), System.Drawing.Image)
        Me.BtnLast.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnLast.Name = "BtnLast"
        Me.BtnLast.Size = New System.Drawing.Size(23, 22)
        Me.BtnLast.Text = "Ultima"
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'GridDef
        '
        Me.GridDef.AllowAddNew = True
        Me.GridDef.AllowColMove = False
        Me.GridDef.AllowColSelect = False
        Me.GridDef.AllowDelete = True
        Me.GridDef.AutoDefautlts = True
        Me.GridDef.AutoSelectRow = True
        Me.GridDef.BtnAddSTD = True
        Me.GridDef.BtnCopySTD = True
        Me.GridDef.BtnCutSTD = True
        Me.GridDef.BtnDelSTD = True
        Me.GridDef.BtnFirstSTD = True
        Me.GridDef.BtnHelpSTD = True
        Me.GridDef.BtnLastSTD = True
        Me.GridDef.BtnNextSTD = True
        Me.GridDef.BtnPasteSTD = True
        Me.GridDef.BtnPrevSTD = True
        Me.GridDef.BtnPrintSTD = True
        Me.GridDef.BtnSaveSTD = True
        Me.GridDef.ConnectionString = ""
        Me.GridDef.DataConnectionIntegra = Nothing
        Me.GridDef.DataSelectString = ""
        Me.GridDef.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridDef.ExtendRightColumn = True
        Me.GridDef.FilterBar = True
        Me.GridDef.GroupByCaption = "Drag a column header here to group by that column"
        Me.GridDef.Images.Add(CType(resources.GetObject("GridDef.Images"), System.Drawing.Image))
        Me.GridDef.Location = New System.Drawing.Point(0, 105)
        Me.GridDef.MultiSelect = C1.Win.C1TrueDBGrid.MultiSelectEnum.None
        Me.GridDef.Name = "GridDef"
        Me.GridDef.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.GridDef.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.GridDef.PreviewInfo.ZoomFactor = 75
        Me.GridDef.PrintInfo.PageSettings = CType(resources.GetObject("GridDef.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.GridDef.RetriveFieldsDesign = False
        Me.GridDef.Size = New System.Drawing.Size(804, 420)
        Me.GridDef.TabAction = C1.Win.C1TrueDBGrid.TabActionEnum.ColumnNavigation
        Me.GridDef.TabIndex = 1
        Me.GridDef.Text = "C1TrueDBGrid2"
        Me.GridDef.ToolStrip = Nothing
        Me.GridDef.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Silver
        Me.GridDef.PropBag = resources.GetString("GridDef.PropBag")
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ChkGridLocked)
        Me.Panel1.Controls.Add(Me.GroupFilter)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.CmbTipoMsg)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 25)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(804, 80)
        Me.Panel1.TabIndex = 7
        '
        'ChkGridLocked
        '
        Me.ChkGridLocked.AutoSize = True
        Me.ChkGridLocked.Checked = True
        Me.ChkGridLocked.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkGridLocked.Location = New System.Drawing.Point(12, 46)
        Me.ChkGridLocked.Name = "ChkGridLocked"
        Me.ChkGridLocked.Size = New System.Drawing.Size(99, 17)
        Me.ChkGridLocked.TabIndex = 22
        Me.ChkGridLocked.Text = "Griglia bloccata"
        Me.ChkGridLocked.UseVisualStyleBackColor = True
        '
        'GroupFilter
        '
        Me.GroupFilter.Controls.Add(Me.TxtFilterNumSubCampo)
        Me.GroupFilter.Controls.Add(Me.TxtFilterNumCampo)
        Me.GroupFilter.Controls.Add(Me.TxtFilterDescrizione)
        Me.GroupFilter.Controls.Add(Me.BtnCancelFilter)
        Me.GroupFilter.Controls.Add(Me.BtnApplyFilter)
        Me.GroupFilter.Controls.Add(Me.LblNumSubCampo)
        Me.GroupFilter.Controls.Add(Me.LblFilterDescrizione)
        Me.GroupFilter.Controls.Add(Me.LblNumCampo)
        Me.GroupFilter.Location = New System.Drawing.Point(331, 3)
        Me.GroupFilter.Name = "GroupFilter"
        Me.GroupFilter.Size = New System.Drawing.Size(462, 71)
        Me.GroupFilter.TabIndex = 3
        Me.GroupFilter.TabStop = False
        Me.GroupFilter.Text = "Filtri"
        '
        'TxtFilterNumSubCampo
        '
        Me.TxtFilterNumSubCampo.FocusBackColor = System.Drawing.Color.LightBlue
        Me.TxtFilterNumSubCampo.FocusForeColor = System.Drawing.Color.Black
        Me.TxtFilterNumSubCampo.KeyPressFormat = Nothing
        Me.TxtFilterNumSubCampo.Location = New System.Drawing.Point(87, 43)
        Me.TxtFilterNumSubCampo.Name = "TxtFilterNumSubCampo"
        Me.TxtFilterNumSubCampo.Size = New System.Drawing.Size(61, 20)
        Me.TxtFilterNumSubCampo.StatusBar = Nothing
        Me.TxtFilterNumSubCampo.StatusBarLenght = Nothing
        Me.TxtFilterNumSubCampo.StatusBarText = Nothing
        Me.TxtFilterNumSubCampo.StatusBarType = Nothing
        Me.TxtFilterNumSubCampo.TabIndex = 16
        '
        'TxtFilterNumCampo
        '
        Me.TxtFilterNumCampo.FocusBackColor = System.Drawing.Color.LightBlue
        Me.TxtFilterNumCampo.FocusForeColor = System.Drawing.Color.Black
        Me.TxtFilterNumCampo.KeyPressFormat = ""
        Me.TxtFilterNumCampo.Location = New System.Drawing.Point(87, 20)
        Me.TxtFilterNumCampo.Name = "TxtFilterNumCampo"
        Me.TxtFilterNumCampo.Size = New System.Drawing.Size(61, 20)
        Me.TxtFilterNumCampo.StatusBar = Me.StatusBar1
        Me.TxtFilterNumCampo.StatusBarLenght = "5"
        Me.TxtFilterNumCampo.StatusBarText = "Identificativo univoco del record in anagrafica"
        Me.TxtFilterNumCampo.StatusBarType = "NUM"
        Me.TxtFilterNumCampo.TabIndex = 15
        Me.TxtFilterNumCampo.ValidatingType = GetType(Integer)
        '
        'TxtFilterDescrizione
        '
        Me.TxtFilterDescrizione.FocusBackColor = System.Drawing.Color.LightBlue
        Me.TxtFilterDescrizione.FocusForeColor = System.Drawing.Color.Black
        Me.TxtFilterDescrizione.KeyPressFormat = Nothing
        Me.TxtFilterDescrizione.Location = New System.Drawing.Point(238, 42)
        Me.TxtFilterDescrizione.Name = "TxtFilterDescrizione"
        Me.TxtFilterDescrizione.Size = New System.Drawing.Size(125, 20)
        Me.TxtFilterDescrizione.StatusBar = Nothing
        Me.TxtFilterDescrizione.StatusBarLenght = Nothing
        Me.TxtFilterDescrizione.StatusBarText = Nothing
        Me.TxtFilterDescrizione.StatusBarType = Nothing
        Me.TxtFilterDescrizione.TabIndex = 19
        '
        'BtnCancelFilter
        '
        Me.BtnCancelFilter.Location = New System.Drawing.Point(377, 42)
        Me.BtnCancelFilter.Name = "BtnCancelFilter"
        Me.BtnCancelFilter.Size = New System.Drawing.Size(73, 23)
        Me.BtnCancelFilter.TabIndex = 21
        Me.BtnCancelFilter.Text = "Annulla"
        Me.BtnCancelFilter.UseVisualStyleBackColor = True
        '
        'BtnApplyFilter
        '
        Me.BtnApplyFilter.Location = New System.Drawing.Point(377, 17)
        Me.BtnApplyFilter.Name = "BtnApplyFilter"
        Me.BtnApplyFilter.Size = New System.Drawing.Size(73, 23)
        Me.BtnApplyFilter.TabIndex = 20
        Me.BtnApplyFilter.Text = "Applica"
        Me.BtnApplyFilter.UseVisualStyleBackColor = True
        '
        'LblNumSubCampo
        '
        Me.LblNumSubCampo.AutoSize = True
        Me.LblNumSubCampo.Location = New System.Drawing.Point(12, 45)
        Me.LblNumSubCampo.Name = "LblNumSubCampo"
        Me.LblNumSubCampo.Size = New System.Drawing.Size(69, 13)
        Me.LblNumSubCampo.TabIndex = 5
        Me.LblNumSubCampo.Text = "N.Subcampo"
        '
        'LblFilterDescrizione
        '
        Me.LblFilterDescrizione.AutoSize = True
        Me.LblFilterDescrizione.Location = New System.Drawing.Point(165, 43)
        Me.LblFilterDescrizione.Name = "LblFilterDescrizione"
        Me.LblFilterDescrizione.Size = New System.Drawing.Size(62, 13)
        Me.LblFilterDescrizione.TabIndex = 3
        Me.LblFilterDescrizione.Text = "Descrizione"
        '
        'LblNumCampo
        '
        Me.LblNumCampo.AutoSize = True
        Me.LblNumCampo.Location = New System.Drawing.Point(30, 23)
        Me.LblNumCampo.Name = "LblNumCampo"
        Me.LblNumCampo.Size = New System.Drawing.Size(51, 13)
        Me.LblNumCampo.TabIndex = 1
        Me.LblNumCampo.Text = "N.Campo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Tipo messaggio"
        '
        'CmbTipoMsg
        '
        Me.CmbTipoMsg.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.CmbTipoMsg.AllowColMove = False
        Me.CmbTipoMsg.AllowSort = False
        Me.CmbTipoMsg.AutoSelect = True
        Me.CmbTipoMsg.Caption = ""
        Me.CmbTipoMsg.CaptionHeight = 17
        Me.CmbTipoMsg.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.CmbTipoMsg.ColumnCaptionHeight = 17
        Me.CmbTipoMsg.ColumnFooterHeight = 17
        Me.CmbTipoMsg.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.CmbTipoMsg.ContentHeight = 15
        Me.CmbTipoMsg.DataMode = C1.Win.C1List.DataModeEnum.AddItem
        Me.CmbTipoMsg.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.CmbTipoMsg.DisplayMember = "descrizione"
        Me.CmbTipoMsg.DropDownWidth = 300
        Me.CmbTipoMsg.EditorBackColor = System.Drawing.SystemColors.Window
        Me.CmbTipoMsg.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbTipoMsg.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.CmbTipoMsg.EditorHeight = 15
        Me.CmbTipoMsg.FocusBackColor = System.Drawing.Color.LightBlue
        Me.CmbTipoMsg.FocusForeColor = System.Drawing.Color.Black
        Me.CmbTipoMsg.Images.Add(CType(resources.GetObject("CmbTipoMsg.Images"), System.Drawing.Image))
        Me.CmbTipoMsg.ItemHeight = 15
        Me.CmbTipoMsg.KeyPressFormat = Nothing
        Me.CmbTipoMsg.LimitToList = True
        Me.CmbTipoMsg.Location = New System.Drawing.Point(99, 12)
        Me.CmbTipoMsg.MatchEntryTimeout = CType(2000, Long)
        Me.CmbTipoMsg.MaxDropDownItems = CType(20, Short)
        Me.CmbTipoMsg.MaxLength = 32767
        Me.CmbTipoMsg.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.CmbTipoMsg.Name = "CmbTipoMsg"
        Me.CmbTipoMsg.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.CmbTipoMsg.Size = New System.Drawing.Size(226, 21)
        Me.CmbTipoMsg.StatusBar = Nothing
        Me.CmbTipoMsg.StatusBarLenght = Nothing
        Me.CmbTipoMsg.StatusBarText = Nothing
        Me.CmbTipoMsg.StatusBarType = Nothing
        Me.CmbTipoMsg.TabIndex = 0
        Me.CmbTipoMsg.ValueMember = "codice"
        Me.CmbTipoMsg.PropBag = resources.GetString("CmbTipoMsg.PropBag")
        '
        'DropObbligatorieta
        '
        Me.DropObbligatorieta.AllowColMove = True
        Me.DropObbligatorieta.AllowColSelect = True
        Me.DropObbligatorieta.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.DropObbligatorieta.AlternatingRows = False
        Me.DropObbligatorieta.CaptionStyle = Style1
        Me.DropObbligatorieta.ColumnCaptionHeight = 17
        Me.DropObbligatorieta.ColumnFooterHeight = 17
        Me.DropObbligatorieta.EvenRowStyle = Style2
        Me.DropObbligatorieta.FetchRowStyles = False
        Me.DropObbligatorieta.FooterStyle = Style3
        Me.DropObbligatorieta.HeadingStyle = Style4
        Me.DropObbligatorieta.HighLightRowStyle = Style5
        Me.DropObbligatorieta.Images.Add(CType(resources.GetObject("DropObbligatorieta.Images"), System.Drawing.Image))
        Me.DropObbligatorieta.Location = New System.Drawing.Point(105, 207)
        Me.DropObbligatorieta.Name = "DropObbligatorieta"
        Me.DropObbligatorieta.OddRowStyle = Style6
        Me.DropObbligatorieta.RecordSelectorStyle = Style7
        Me.DropObbligatorieta.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.DropObbligatorieta.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.[Single]
        Me.DropObbligatorieta.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.DropObbligatorieta.ScrollTips = False
        Me.DropObbligatorieta.Size = New System.Drawing.Size(220, 129)
        Me.DropObbligatorieta.Style = Style8
        Me.DropObbligatorieta.TabIndex = 8
        Me.DropObbligatorieta.TabStop = False
        Me.DropObbligatorieta.Text = "DropObbligatorieta"
        Me.DropObbligatorieta.Visible = False
        Me.DropObbligatorieta.PropBag = resources.GetString("DropObbligatorieta.PropBag")
        '
        'DropFormatoTipo
        '
        Me.DropFormatoTipo.AllowColMove = True
        Me.DropFormatoTipo.AllowColSelect = True
        Me.DropFormatoTipo.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.DropFormatoTipo.AlternatingRows = False
        Me.DropFormatoTipo.CaptionStyle = Style9
        Me.DropFormatoTipo.ColumnCaptionHeight = 17
        Me.DropFormatoTipo.ColumnFooterHeight = 17
        Me.DropFormatoTipo.EvenRowStyle = Style10
        Me.DropFormatoTipo.FetchRowStyles = False
        Me.DropFormatoTipo.FooterStyle = Style11
        Me.DropFormatoTipo.HeadingStyle = Style12
        Me.DropFormatoTipo.HighLightRowStyle = Style13
        Me.DropFormatoTipo.Images.Add(CType(resources.GetObject("DropFormatoTipo.Images"), System.Drawing.Image))
        Me.DropFormatoTipo.Location = New System.Drawing.Point(331, 207)
        Me.DropFormatoTipo.Name = "DropFormatoTipo"
        Me.DropFormatoTipo.OddRowStyle = Style14
        Me.DropFormatoTipo.RecordSelectorStyle = Style15
        Me.DropFormatoTipo.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.DropFormatoTipo.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.[Single]
        Me.DropFormatoTipo.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.DropFormatoTipo.ScrollTips = False
        Me.DropFormatoTipo.Size = New System.Drawing.Size(207, 97)
        Me.DropFormatoTipo.Style = Style16
        Me.DropFormatoTipo.TabIndex = 9
        Me.DropFormatoTipo.TabStop = False
        Me.DropFormatoTipo.Text = "DropFormatoTipo"
        Me.DropFormatoTipo.Visible = False
        Me.DropFormatoTipo.PropBag = resources.GetString("DropFormatoTipo.PropBag")
        '
        'DefMessaggi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(804, 547)
        Me.Controls.Add(Me.DropFormatoTipo)
        Me.Controls.Add(Me.DropObbligatorieta)
        Me.Controls.Add(Me.GridDef)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "DefMessaggi"
        Me.Text = "Definizione struttura messaggi"
        Me.Controls.SetChildIndex(Me.StatusBar1, 0)
        Me.Controls.SetChildIndex(Me.ToolStrip1, 0)
        Me.Controls.SetChildIndex(Me.Panel1, 0)
        Me.Controls.SetChildIndex(Me.GridDef, 0)
        Me.Controls.SetChildIndex(Me.DropObbligatorieta, 0)
        Me.Controls.SetChildIndex(Me.DropFormatoTipo, 0)
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.GridDef, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupFilter.ResumeLayout(False)
        Me.GroupFilter.PerformLayout()
        CType(Me.CmbTipoMsg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DropObbligatorieta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DropFormatoTipo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents BtnFirst As System.Windows.Forms.ToolStripButton
    Friend WithEvents BtnPrev As System.Windows.Forms.ToolStripButton
    Friend WithEvents BtnAdd As System.Windows.Forms.ToolStripButton
    Friend WithEvents BtnDel As System.Windows.Forms.ToolStripButton
    Friend WithEvents BtnNext As System.Windows.Forms.ToolStripButton
    Friend WithEvents BtnLast As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents GridDef As FlexGroup.C1TrueDBGridIntegra 'C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents C1Combo1 As FlexGroup.C1ComboBoxIntegraV2 'C1.Win.C1List.C1Combo
    Friend WithEvents CmbTipoMsg As FlexGroup.C1ComboBoxIntegraV2 'C1.Win.C1List.C1Combo
    Friend WithEvents GroupFilter As System.Windows.Forms.GroupBox
    Friend WithEvents LblNumSubCampo As System.Windows.Forms.Label
    Friend WithEvents LblFilterDescrizione As System.Windows.Forms.Label
    Friend WithEvents LblNumCampo As System.Windows.Forms.Label
    Friend WithEvents BtnApplyFilter As System.Windows.Forms.Button
    Friend WithEvents BtnCancelFilter As System.Windows.Forms.Button
    Friend WithEvents TxtFilterDescrizione As FunzioniIntegra.TextBoxIntegra
    Friend WithEvents TxtFilterNumSubCampo As FunzioniIntegra.TextBoxIntegra
    Friend WithEvents TxtFilterNumCampo As FunzioniIntegra.TextBoxIntegra
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents DropObbligatorieta As C1.Win.C1TrueDBGrid.C1TrueDBDropdown
    Friend WithEvents ChkGridLocked As System.Windows.Forms.CheckBox
    Friend WithEvents DropFormatoTipo As C1.Win.C1TrueDBGrid.C1TrueDBDropdown

End Class
