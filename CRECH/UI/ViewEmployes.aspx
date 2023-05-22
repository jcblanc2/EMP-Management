<%@ Page Title="" Language="C#" MasterPageFile="~/UI/Site.Master" AutoEventWireup="true" CodeBehind="ViewEmployes.aspx.cs" Inherits="CRECH.UI.ViewEmployes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>LISTE EMPLOYES</title>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="jumbotron text-center">
        <h2 class="display-1">LISTE EMPLOYES</h2>
    </div>

    <br />

    <div class="col-lg-8" style="margin-left: 40px">
        <div class="form-inline">
            <div class="form-group mx-sm-3 mb-2">
                <asp:TextBox class="form-control" ID="txtNomEmploye" runat="server" OnTextChanged="txtNomEmploye_TextChanged" />
                <asp:Button class="btn btn-primary mb-2" style="margin-left:10px" Text="Search" runat="server" ID="btnSearch" TabIndex="1" OnClick="btnSearch_Click" />
            </div>
        </div>

        <br />

        <div style="overflow: auto; width: 1100px; max-height: 500px;">
            <asp:GridView ID="EmployesGridView" runat="server" AutoGenerateColumns="false"
                DataKeyNames="EmployeID" OnRowEditing="OnRowEditing"
                OnRowCancelingEdit="OnRowCancelingEdit" OnRowUpdating="OnRowUpdating"
                OnRowDeleting="OnRowDeleting" EmptyDataText="No records has been added."
                Width="700px" Height="90px">
                <Columns>
                    <asp:TemplateField HeaderText="Name">
                        <ItemTemplate>
                            <asp:Label ID="lblName" runat="server" Text='<%# Eval("Nom") %>'></asp:Label>
                        </ItemTemplate>

                        <EditItemTemplate>
                            <asp:TextBox ID="txtName" runat="server" Text='<%# Eval("Nom") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Prenom">
                        <ItemTemplate>
                            <asp:Label ID="lblPrenom" runat="server" Text='<%# Eval("Prenom") %>'></asp:Label>
                        </ItemTemplate>

                        <EditItemTemplate>
                            <asp:TextBox ID="txtPrenom" runat="server" Text='<%# Eval("Prenom") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Sexe">
                        <ItemTemplate>
                            <asp:Label ID="lblSexe" runat="server" Text='<%# Eval("Sexe") %>'></asp:Label>
                        </ItemTemplate>

                        <EditItemTemplate>
                            <asp:TextBox ID="txtSexe" runat="server" Text='<%# Eval("Sexe") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Telephone">
                        <ItemTemplate>
                            <asp:Label ID="lblTelephone" runat="server" Text='<%# Eval("Telephone") %>'></asp:Label>
                        </ItemTemplate>

                        <EditItemTemplate>
                            <asp:TextBox ID="txtTelephone" runat="server" Text='<%# Eval("Telephone") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>

                    <asp:CommandField ControlStyle-CssClass="btn btn-outline-dark" ButtonType="Link" ShowEditButton="true"  ShowDeleteButton="true" />
                </Columns>
            </asp:GridView>
        </div>
    </div>
    <br />
    <br />
</asp:Content>
