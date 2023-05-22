<%@ Page Title="" Language="C#" MasterPageFile="~/UI/Site.Master" AutoEventWireup="true" CodeBehind="PromotionPage.aspx.cs" Inherits="CRECH.UI.PromotionPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Promotion</title>
    <script>
        $(document).ready(function () {
            $(".table").prepend($("<thead></thead>").append($(this).find("tr:first"))).dataTable();
        });
    </script>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <%-- DIFFERENT DEPARTEMENTS --%>
    <div class="jumbotron text-center">
        <h2 class="display-1">PACOURS AU SEIN DE L'ORGANISATION</h2>
    </div>

    <div class="container-fluid">
        <div class="row">
            <div class="col-md-5">
                <div class="card">
                    <div class="card-body">

                        <div class="row">
                            <div class="col-md-5">
                                <asp:TextBox class="form-control" placeholder="Nom Complet" ID="NomTextBox" runat="server"></asp:TextBox>
                            </div>

                            <div class="col-md-5">
                                <div class="form-group">
                                    <asp:TextBox class="form-control" placeholder="Id Employe" ID="IdEmployeTextBox" runat="server"></asp:TextBox>
                                </div>
                            </div>
                        </div>

                        <div class="row">
                            <div class="col-md-5">
                                <asp:DropDownList ID="DropPoste" runat="server" ValidateRequestMode="Enabled" TabIndex="1">
                                    <asp:ListItem Selected="True">Fonction</asp:ListItem>
                                    <asp:ListItem>Manager</asp:ListItem>
                                </asp:DropDownList>
                            </div>

                            <div class="col-md-4">
                                <div class="form-group">
                                    <asp:DropDownList ID="DropDepartement" runat="server" TabIndex="1">
                                        <asp:ListItem Selected="True">Departement</asp:ListItem>
                                        <asp:ListItem>Conception</asp:ListItem>
                                        <asp:ListItem>Comptabilite</asp:ListItem>
                                        <asp:ListItem>Communication</asp:ListItem>
                                        <asp:ListItem>Formation</asp:ListItem>
                                        <asp:ListItem>Logistique</asp:ListItem>
                                        <asp:ListItem>Production</asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                            </div>
                        </div>

                        <div class="row">
                            <div class="col-md-5">
                                <asp:TextBox class="form-control" ID="txtDebutFonction" Placeholder="Date d'entree en fonction" runat="server"></asp:TextBox>
                            </div>

                            <div class="col-md-6">
                                <div class="form-group">
                                    <asp:TextBox class="form-control" ID="txtFinFonction" Placeholder="Date fin de fonction" runat="server"></asp:TextBox>
                                </div>
                            </div>
                        </div>

                        <div class="row text-center">
                            <div class="col-4">
                                <asp:Button ID="btnCancel" CssClass="btn btn-block btn-secondary" runat="server" Text="Cancel" OnClick="btnCancel_Click" />
                            </div>

                            <div class="col-4">
                                <asp:Button CssClass="btn btn-block btn-primary" ID="btnSave" runat="server" Text="Add" OnClick="btnSave_Click" />
                            </div>
                        </div>
                    </div>
                    <br />
                </div>
            </div>

            <div class="col-md-7">
                <div class="card">
                    <div class="card-body">
                        <div class="row">
                            <div class="col text-center">
                                <h3>Liste des Promotions</h3>
                            </div>
                        </div>
                        <br />
                        <div class="row">
                            <div class="col">
                                <asp:GridView ID="PromotionGridView" CssClass="table table-striped table-bordered table-responsive" runat="server" AutoGenerateColumns="False" DataKeyNames="PromotionID">
                                    <Columns>
                                        <asp:BoundField DataField="NomEmploye" HeaderText="Nom de l'Employe" SortExpression="Nom de l'Employe" />
                                        <asp:BoundField DataField="Departement" HeaderText="Departement" SortExpression="Departement" />
                                        <asp:BoundField DataField="Poste" HeaderText="Poste" SortExpression="Poste" />
                                        <asp:BoundField DataField="DateDebut" HeaderText="Date Debut" SortExpression="Date Debut" />
                                        <asp:BoundField DataField="DateFin" HeaderText="Date Fin" SortExpression="Date Fin" />
                                    </Columns>
                                </asp:GridView>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <br />
    <asp:Label ID="Label1" class="label label-primary" runat="server"></asp:Label>

    <br />
    <br />
    <br />
</asp:Content>
