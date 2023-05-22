<%@ Page Title="" Language="C#" MasterPageFile="~/UI/Site.Master" AutoEventWireup="true" CodeBehind="ParcoursPage.aspx.cs" Inherits="CRECH.UI.ParcoursPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Parcours</title>
    <script>
        $(document).ready(function () {
            $(".table").prepend($("<thead></thead>").append($(this).find("tr:first"))).dataTable();
        });
    </script>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <%-- DIFFERENT DEGREE --%>
    <div class="jumbotron text-center">
        <h2 class="display-1">PACOURS PROFESSIONNEL</h2>
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
                            <div class="col-md-4">
                                <asp:DropDownList ID="DropDetention" runat="server" ValidateRequestMode="Enabled">
                                    <asp:ListItem Selected="True">Certificat</asp:ListItem>
                                    <asp:ListItem>Licence</asp:ListItem>
                                    <asp:ListItem>Maitrise</asp:ListItem>
                                    <asp:ListItem>Doctorat</asp:ListItem>
                                </asp:DropDownList>
                            </div>

                            <div class="col-md-7">
                                <div class="form-group">
                                    <asp:TextBox class="form-control" ID="DateTextBox" Placeholder="Annee de l'obtention" runat="server"></asp:TextBox>
                                </div>
                            </div>

                        </div>
                        
                            <div class="row">
                                <div class="col-4">
                                    <asp:Button ID="Button1" CssClass="btn btn-block btn-secondary" runat="server" Text="Cancel" OnClick="btnCancel_Click" />
                                </div>

                                <div class="col-4">
                                    <asp:Button CssClass="btn btn-block btn-primary" ID="Button2" runat="server" Text="Add" OnClick="btnSave_Click" />
                                </div>
                            </div>
                        <br />
                    </div>
                </div>
            </div>

            <div class="col-md-5">
                <div class="card">
                    <div class="card-body">
                        <div class="row">
                            <div class="col">
                                <asp:GridView ID="ParcoursGridView" CssClass="table table-striped table-bordered table-responsive" runat="server" AutoGenerateColumns="False" DataKeyNames="id">
                                    <Columns>
                                        <asp:BoundField DataField="NomEmploye" HeaderText="Nom" SortExpression="Nom" />
                                        <asp:BoundField DataField="IdEmployePub" HeaderText="ID" SortExpression="ID" />
                                        <asp:BoundField DataField="Discipline" HeaderText="Discipline" SortExpression="Discipline" />
                                        <asp:BoundField DataField="Date" HeaderText="Date" SortExpression="Date" />
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
    <br />
</asp:Content>
