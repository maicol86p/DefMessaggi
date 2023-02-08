Imports FunzioniIntegra
Imports Integra.WebAcsi
Imports Integra.WebAcsi.Messaggi
Imports System.ComponentModel
Imports C1.Win.C1TrueDBGrid
Imports System.Windows.Forms
Imports Integra.WebAcsi.Database
Imports System.Globalization
'Imports PigeonCms


Public Class DefMessaggi
    Inherits BaseForm

    Private Class NameValue
        Public Sub New(ByVal name As String, ByVal value As String)
            Me._name = name
            Me._value = value
        End Sub

        Dim _name As String = ""
        ReadOnly Property Name() As String
            Get
                Return _name
            End Get
        End Property

        Dim _value As String = ""
        ReadOnly Property Value() As String
            Get
                Return _value
            End Get
        End Property
    End Class

    ReadOnly Property TipoMsg()
        Get
            TipoMsg = CmbTipoMsg.SelectedValue
        End Get
    End Property


    Private Sub DefMessaggi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MyBase.Form_Load(sender, e)

        Database.ConnString = Globali.databaseManager.getConnectionString()
        PgnUserCurrent.UserName = Globali.utente
        PgnUserCurrent.AccessCode = Globali.codiceSocieta

        loadCmbTipoMsg()
        loadCmbObbligatorieta()
        loadCmbFormatoTipo()
    End Sub

    Private Sub lockGrid(ByVal lock As Boolean)
        With GridDef
            .AllowAddNew = Not lock
            .AllowUpdate = Not lock
            .AllowDelete = Not lock
        End With
    End Sub

    Private Sub loadCmbTipoMsg()
        CmbTipoMsg.HoldFields()
        CmbTipoMsg.AddItem("IE801;IE801 - DAA elettronico")
        CmbTipoMsg.AddItem("IE810;IE810 - Annullamento DAA elettronico")
        CmbTipoMsg.AddItem("IE815_A;IE815 TRK=A - Draft DAA elettronico")
        CmbTipoMsg.AddItem("IE815_B;IE815 TRK=B - Draft DAA elettronico - DAA non scorta merce")
        CmbTipoMsg.AddItem("IE815_C;IE815 TRK=C - Draft DAA elettronico - Ulteriori dettagli DAA")
        CmbTipoMsg.AddItem("IE813_E;IE813 TRK=E - DAA - Cambio di destinazione")
        CmbTipoMsg.AddItem("IE813_F;IE813 TRK=F - DAA - Cambio di destinazione - DAA non scorta merce")
        CmbTipoMsg.AddItem("IE818_J;IE818 TRK=J - Rapporto di Ricezione/Esportazione")
        CmbTipoMsg.AddItem("IE818_K;IE818 TRK=K - Rapporto di Ricezione/Esportazione")
        CmbTipoMsg.AddItem("IE871_Y;IE871 TRK=Y - Spiegazione sul motivo di un calo")
        CmbTipoMsg.AddItem("IE871_Z;IE871 TRK=Z - Spiegazione sul motivo di un calo")
        CmbTipoMsg.AddItem("IE819_R;IE819 TRK=R - Rigetto o Segnalazione di un DAA Elettronico")
        CmbTipoMsg.AddItem("DettCertificati;DETTAGLI - Certificati")
        CmbTipoMsg.AddItem("DettDAU;DETTAGLI - DAU di Importazione")
        CmbTipoMsg.AddItem("DettDettagliDaa;DETTAGLI - Dettagli del DAA")
        CmbTipoMsg.AddItem("DettGaranti;DETTAGLI - Garanti")
        CmbTipoMsg.AddItem("DettImballaggi;DETTAGLI - Imballaggi")
        CmbTipoMsg.AddItem("DettInsoddisfazione;DETTAGLI - Motivi di Insoddisfazione")
        CmbTipoMsg.AddItem("DettRigetto;DETTAGLI - Motivi di Rigetto o Segnalazione")
        CmbTipoMsg.AddItem("DettTrasporto;DETTAGLI - Dettagli del Trasporto")
        CmbTipoMsg.AddItem("DettTrattamentiVino;DETTAGLI - Trattamenti del Vino")
        CmbTipoMsg.AddItem("IDOC;Interchange IDoc")
    End Sub

    Sub formatGridDef()
        'Dim grid = GridDef
        'Dim drop As New C1TrueDBDropdown

        'For Each item As C1.Win.C1TrueDBGrid.C1DataColumn In GridDef.Columns
        '    Dim txt As New TextBoxIntegra()
        '    txt.BorderStyle = BorderStyle.None
        '    txt.StatusBar = StatusBar1
        '    txt.StatusBarText = item.Caption
        '    txt.StatusBarType = "ALFA"
        '    txt.StatusBarLenght = 10
        '    txt.KeyPressFormat = StrDup(10, "A")
        '    item.Editor = txt
        'Next
    End Sub

    Private Sub loadCmbObbligatorieta()
        Dim ds As New List(Of NameValue)
        ds.Add(New NameValue("R", "Richiesta"))
        ds.Add(New NameValue("O", "Opzionale"))
        ds.Add(New NameValue("C", "Condizionale"))
        ds.Add(New NameValue("D", "Dipendente"))
        DropObbligatorieta.DataSource = ds
        DropObbligatorieta.SetDataBinding(ds, "", False)
    End Sub

    Private Sub loadCmbFormatoTipo()
        Dim ds As New List(Of NameValue)
        ds.Add(New NameValue("A", "Alfabetico"))
        ds.Add(New NameValue("N", "Numerico"))
        ds.Add(New NameValue("AN", "AlfaNumerico"))
        DropFormatoTipo.DataSource = ds
        DropFormatoTipo.SetDataBinding(ds, "", False)
    End Sub

    Private Sub loadControlType()
        '<asp:DropDownList ID="DropControlType" runat="server" CssClass="adminMediumText" MaxLength="255">
        '<asp:ListItem Value="textbox">TextBox</asp:ListItem>
        '<asp:ListItem Value="dropdownlist">DropDownList</asp:ListItem>
        '<asp:ListItem Value="literal">Literal</asp:ListItem>
        '<asp:ListItem Value="checkbox">CheckBox</asp:ListItem>
        '<asp:ListItem Value="hidden">Hidden</asp:ListItem>
        '<asp:ListItem Value="calendar">Calendar</asp:ListItem>
        '</asp:DropDownList>
    End Sub

    Sub loadGridDef()
        loadGridDef("")
    End Sub

    Sub loadGridDef(ByVal sort As String)
        Try
            lockGrid(ChkGridLocked.Checked)

            Dim man As New Integra.WebAcsi.DaaDefMessaggiManager()
            Dim filter As New Integra.WebAcsi.DaaDefMessaggioFilter()
            filter.TipoMessaggio = Me.TipoMsg

            Dim intParam = 0
            If Integer.TryParse(TxtFilterNumCampo.Text, intParam) Then
                filter.NumCampo = intParam.ToString()
            End If
            intParam = 0
            If Integer.TryParse(TxtFilterNumSubCampo.Text, intParam) Then
                filter.NumSubCampo = intParam.ToString()
            End If
            filter.DescrizioneCampo = TxtFilterDescrizione.Text

            Dim ds As New BindingList(Of DaaDefMessaggio)(man.GetByFilter(filter, sort))
            GridDef.SetDataBinding(ds, "", True)
            'GridDef.Rebind(True)

        Catch ex As Exception
            GestioneErrori.erroreStandard(ex)
        End Try
    End Sub

    Private Sub GridDef_BeforeDelete1(ByVal sender As Object, ByRef e As Boolean) Handles GridDef.BeforeDelete

    End Sub

    Private Sub GridDef_OnAddNew(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridDef.OnAddNew
        GridDef.Columns("Id").Value = 0   'per identificare nuova riga
        GridDef.Columns("FormatoTipo").Value = "AN"
        GridDef.Columns("Obbligatorieta").Value = "R"
    End Sub

    Private Sub GridDef_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles GridDef.MouseClick
        If CType(sender, C1.Win.C1TrueDBGrid.C1TrueDBGrid).Row > -1 Then
            CType(sender, C1.Win.C1TrueDBGrid.C1TrueDBGrid).SelectedRows.Add(CType(sender, C1TrueDBGrid).Row)
        End If

    End Sub

    Private Sub GridDef_BeforeUpdate(ByVal sender As System.Object, ByVal e As C1.Win.C1TrueDBGrid.CancelEventArgs) Handles GridDef.BeforeUpdate
        Dim grid = CType(sender, C1TrueDBGrid)
        Dim man As New DaaDefMessaggiManager()
        Dim row As New DaaDefMessaggio()
        Try
            Dim ds As BindingList(Of DaaDefMessaggio) = grid.DataSource
            row = ds(grid.Bookmark)
            If row.Id > 0 Then
                man.Update(row)
            Else
                row.TipoMessaggio = Me.TipoMsg
                man.Insert(row)
            End If

        Catch ex As Exception
            e.Cancel = True
            GestioneErrori.erroreStandard(ex)
        End Try

    End Sub

    Private Sub GridDef_BeforeDelete(ByVal sender As Object, ByRef e As Boolean) Handles GridDef.BeforeDelete
        If MessageBox.Show("Cancellare il record?", "Conferma cancellazione", _
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
            e = True
        Else
            Try
                Dim grid = CType(sender, C1TrueDBGrid)
                Dim man As New DaaDefMessaggiManager()
                Dim row As New DaaDefMessaggio()
                Dim ds As BindingList(Of DaaDefMessaggio) = grid.DataSource
                row = ds(grid.Row)
                man.DeleteById(row.Id)
            Catch ex As Exception
                e = True
                GestioneErrori.erroreStandard(ex)
            End Try
        End If
    End Sub

    Private Sub GridDef_HeadClick(ByVal sender As System.Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles GridDef.HeadClick
        Dim dc As C1.Win.C1TrueDBGrid.C1DisplayColumn = GridDef.Splits(0).DisplayColumns(e.ColIndex)
        Dim newsort As SortDir = SortDir.None
        Select Case CType(dc.DataColumn.Tag, SortDir)
            Case SortDir.None, SortDir.Desc
                newsort = SortDir.Asc
            Case Else
                newsort = SortDir.Desc
        End Select

        Dim col As C1.Win.C1TrueDBGrid.C1DisplayColumn
        For Each col In Me.GridDef.Splits(0).DisplayColumns
            col.DataColumn.Tag = SortDir.None
        Next col

        Dim sortCondition As String = dc.DataColumn.DataField + " "
        sortCondition += IIf(newsort = SortDir.Desc, "DESC", "")

        loadGridDef(sortCondition)
        dc.DataColumn.Tag = newsort
    End Sub

    Private Sub CmbTipoMsg_Change(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbTipoMsg.Change
        loadGridDef()
    End Sub

    Private Sub BtnApplyFilter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnApplyFilter.Click
        loadGridDef()
    End Sub

    Private Sub BtnCancelFilter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelFilter.Click
        TxtFilterNumCampo.Text = ""
        TxtFilterNumSubCampo.Text = ""
        TxtFilterDescrizione.Text = ""
        loadGridDef()
    End Sub

    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click
        Dim ds As BindingList(Of DaaDefMessaggio) = GridDef.DataSource
        GridDef.Focus()
        GridDef.Row = ds.Count
    End Sub

    Private Sub BtnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNext.Click
        GridDef.Focus()
        GridDef.Row += 1
    End Sub

    Private Sub BtnPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrev.Click
        GridDef.Focus()
        GridDef.Row -= 1
    End Sub

    Private Sub BtnFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFirst.Click
        GridDef.Focus()
        GridDef.Row = 0
    End Sub

    Private Sub BtnLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLast.Click
        Dim ds As BindingList(Of DaaDefMessaggio) = GridDef.DataSource
        GridDef.Focus()
        If ds.Count > 0 Then
            GridDef.Row = ds.Count - 1
        End If
    End Sub

    Private Sub BtnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDel.Click
        Try
            Dim grid = GridDef
            'Dim cancel As C1.Win.C1TrueDBGrid.CancelEventArgs
            GridDef_BeforeDelete(grid, False)
            grid.Delete()
        Catch ex As Exception
            GestioneErrori.erroreStandard(ex)
        End Try
    End Sub

    Private Sub ChkGridLocked_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkGridLocked.CheckedChanged
        lockGrid(ChkGridLocked.Checked)
    End Sub
End Class
