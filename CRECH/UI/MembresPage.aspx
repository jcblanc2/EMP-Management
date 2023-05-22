<%@ Page Title="" Language="C#" MasterPageFile="~/UI/Site.Master" AutoEventWireup="true" CodeBehind="MembresPage.aspx.cs" Inherits="CRECH.UI.MembresPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script>
        $(document).ready(function () {
            $(".table").prepend($("<thead></thead>").append($(this).find("tr:first"))).dataTable();
        });
    </script>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid">
        <div class="row">
            <div class="col-md-6">
                <div class="card" style="margin: 30px">
                    <div class="card-body">

                        <div class="row">
                            <div class="col text-center">
                                <h3>Member Details</h3>
                            </div>
                        </div>

                        <div class="row">
                            <div class="col text-center">
                                <img width="100px" src="../Images/generaluser.png" />
                            </div>
                        </div>
                        <br />
                        <div class="row">
                            <div class="col-md-5">
                                <label for="body_MemberUsernameTextBox">Username</label>
                                <div class="form-group">
                                    <div class="input-group">
                                        <asp:TextBox class="form-control" placeholder="Username" ID="MemberUsernameTextBox" runat="server"></asp:TextBox>
                                        <asp:Button CssClass="btn btn-primary" ID="GoButton" runat="server" Text="Go" OnClick="GoButton_Click" />
                                    </div>
                                </div>
                            </div>

                            <div class="col-md-4">
                                <label for="body_FullNameTextBox">Nom Complet</label>
                                <div class="form-group">
                                    <asp:TextBox class="form-control" placeholder="Nom Complet" ID="FullNameTextBox" runat="server"></asp:TextBox>
                                </div>
                            </div>
                        </div>

                        <div class="row">
                            <div class="col-md-5">
                                <label for="body_PwdTextBox">Mot de Passe</label>
                                <asp:TextBox class="form-control" placeholder="Mot de Passe" ID="PwdTextBox" runat="server"></asp:TextBox>
                            </div>

                            <div class="col-md-4">
                                <div class="form-group">
                                    <label for="body_StatusDropDownList">Status</label>
                                    <asp:DropDownList CssClass="form-control" ID="StatusDropDownList" runat="server">
                                        <asp:ListItem Text="-- SELECT --" Selected="True" />
                                        <asp:ListItem Text="Actif" Value="1" />
                                        <asp:ListItem Text="Inactif" Value="0" />
                                    </asp:DropDownList>
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-4">
                                <asp:Button CssClass="btn btn-block btn-success" ID="AddMember" runat="server" Text="Add" OnClick="AddMember_Click" />
                            </div>
                            <div class="col-4">
                                <asp:Button CssClass="btn btn-block btn-primary" ID="UpdateMember" runat="server" Text="Update" OnClick="UpdateMember_Click" />
                            </div>
                            <div class="col-4">
                                <asp:Button CssClass="btn btn-block btn-danger" ID="DeleteMember" runat="server" Text="Delete" OnClick="DeleteMember_Click" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>

            <div class="col-md-6">
                <div class="card" style="margin: 30px">
                    <div class="card-body">
                        <div class="row">
                            <div class="col text-center">
                                <h3>Liste des Membres</h3>
                            </div>
                        </div>
                        <br>
                        <div class="row">
                            <div class="col">
                                <asp:GridView ID="MemberGridView" CssClass="table table-striped table-bordered table-responsive" runat="server" AutoGenerateColumns="False" DataKeyNames="MemberID">
                                    <Columns>
                                        <asp:BoundField DataField="FullName" HeaderText="Nom Complet" SortExpression="NomComplet" />
                                        <asp:BoundField DataField="Username" HeaderText="Username" SortExpression="Username" />
                                        <asp:BoundField DataField="Password" HeaderText="Password" SortExpression="Password" />
                                        <asp:BoundField DataField="Actif" HeaderText="Status" SortExpression="Status" />
                                    </Columns>
                                </asp:GridView>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
