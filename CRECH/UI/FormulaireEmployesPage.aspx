<%@ Page Title="" Language="C#" MasterPageFile="~/UI/Site.Master" AutoEventWireup="true" CodeBehind="FormulaireEmployesPage.aspx.cs" Inherits="CRECH.FormulaireEmployesPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>FORME EMPLOYES</title>
   
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="jumbotron text-center">
        <h1 class="display-1">FORMULAIRE EMPLOYES</h1>
    </div>

    <br />
    <br />
    <br />

    <div class="col-lg-12">
        <div class="col-lg-12">

            <div class="row">
                <div class="col-lg-4">
                    <asp:TextBox ID="txtNom" runat="server" CssClass="form-control" Placeholder="Nom" EnableViewState="False" ValidateRequestMode="Enabled" ViewStateMode="Disabled"></asp:TextBox>
                </div>

                <div class="col-lg-4">
                    <asp:TextBox ID="txtPrenom1" runat="server" CssClass="form-control" Placeholder="Prenom" ValidateRequestMode="Enabled" ViewStateMode="Disabled"></asp:TextBox>
                </div>

                <div class="col-lg-4">
                    <asp:TextBox ID="txtPrenom2" CssClass="form-control" Placeholder="Prenom" runat="server"></asp:TextBox>
                </div>
            </div>
            <br />
            <div class="row">
                <div class="col-lg-4">
                    <asp:TextBox ID="txtDateNaissance" runat="server" CssClass="form-control" Placeholder="Date de naissance" TextMode="DateTime" ValidateRequestMode="Enabled"></asp:TextBox>
                </div>

                <div class="col-lg-4">
                    <asp:TextBox ID="txtTelephone" runat="server" CssClass="form-control" Placeholder="Telephone" TextMode="Phone" ValidateRequestMode="Enabled"></asp:TextBox>
                </div>

                <div class="col-lg-4">
                    <asp:TextBox ID="txtDateEmbauche" Placeholder="Date d'embauche" runat="server" CssClass="form-control" TextMode="DateTime" ValidateRequestMode="Enabled"></asp:TextBox>
                </div>
            </div>
            <br />
            <div class="row">
                <div class="col-lg-4">
                    <asp:TextBox ID="txtEmail" Placeholder="Email" runat="server" CssClass="form-control" TextMode="Email" ValidateRequestMode="Enabled"></asp:TextBox>
                </div>

                <div class="col-lg-4">
                    <asp:TextBox ID="txtAdresse" Placeholder="Adresse" runat="server" CssClass="form-control"></asp:TextBox>
                </div>

                <div class="col-lg-4">
                    <asp:DropDownList ID="DropSex" runat="server" ValidateRequestMode="Enabled" Placeholder="Sexe">
                        <asp:ListItem Selected="True">Sexe</asp:ListItem>
                        <asp:ListItem>Femme</asp:ListItem>
                        <asp:ListItem>Homme</asp:ListItem>
                    </asp:DropDownList>
                </div>
            </div>
        </div>
    </div>

    <asp:Label ID="Label1" class="label label-primary" runat="server"></asp:Label>

    <br />
    <%-- CONTACT INFORMATION --%>
    <br />
    <br />
    <br />

    <div class="jumbotron text-center">
        <h2 class="display-1">PERSONNE A CONTACTER</h2>
    </div>

    <div class="row">
        <div class="col-lg-12">
            <div class="col-lg-12">
                <div class="row">
                    <div class="col-lg-4">
                        <asp:TextBox ID="txtNomContact" runat="server" CssClass="form-control" Placeholder="Nom" EnableViewState="False" ValidateRequestMode="Enabled" ViewStateMode="Disabled"></asp:TextBox>
                    </div>

                    <div class="col-lg-4">
                        <asp:TextBox ID="txtPrenomContact" runat="server" CssClass="form-control" Placeholder="Prenom" ValidateRequestMode="Enabled" ViewStateMode="Disabled"></asp:TextBox>
                    </div>

                    <div class="col-lg-4">
                        <asp:TextBox ID="txtTelContact" runat="server" CssClass="form-control" Placeholder="Telephone" TextMode="Phone" ValidateRequestMode="Enabled"></asp:TextBox>
                    </div>
                </div>
                <br />
                <div class="row">
                    <div class="col-lg-4">
                        <asp:DropDownList ID="DropLien" runat="server" ValidateRequestMode="Enabled" Placeholder="Lien de parente" TabIndex="1">
                            <asp:ListItem Selected="True">Lien de parente</asp:ListItem>
                            <asp:ListItem>Epouse</asp:ListItem>
                            <asp:ListItem>Epoux</asp:ListItem>
                            <asp:ListItem>Mere</asp:ListItem>
                            <asp:ListItem>Pere</asp:ListItem>
                            <asp:ListItem>Frere</asp:ListItem>
                            <asp:ListItem>Soeur</asp:ListItem>
                            <asp:ListItem>Autres</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                </div>
            </div>
        </div>
    </div>


    <br />
    <br />

    <div class="row justify-content-md-center">
        <div class="col-2">
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" CssClass="btn btn-block btn-secondary" OnClick="btnCancel_Click" />
        </div>

        <div class="col-2">
            <asp:Button ID="AddEmp" runat="server" Text="Add" CssClass="btn btn-block btn-primary" OnClick="btnAddEmp_Click" />
        </div>
    </div>

    <br />
    <br />
    <br />
    <br />
</asp:Content>
