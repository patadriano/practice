﻿<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SimpleCRUD._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <section class="row" aria-labelledby="aspnetTitle">
            <h1 id="aspnetTitle">ASP.NET</h1>
            <p class="lead">ASP.NET is a free web framework for building great Web sites and Web applications using HTML, CSS, and JavaScript.</p>
            <p><a href="http://www.asp.net" class="btn btn-primary btn-md">Learn more &raquo;</a></p>
        </section>

        <div class="row">
            <asp:UpdatePanel runat="server" ID="UpdatePanel2"  UpdateMode="Conditional" ChildrenAsTriggers="true" >
                <ContentTemplate>
                    <br>
                    <asp:Label ID="Name" Text="Name" runat="server" />
                    <asp:TextBox runat="server" ID="txtName" />
                     <br>
                    <asp:Label ID="Age" Text="Age" runat="server" />
                    <asp:TextBox runat="server" ID="txtAge" />
                    <br>
                    <asp:Button ID="AddPerson" Text="Add" runat="server" OnClick="btnAddPerson_Click" />
                    <%--<asp:Button ID="EditPerson" Text="Edit" runat="server" OnClick="btnEditPerson_Click" />
                    <asp:Button ID="DeletePerson" Text="Delete" runat="server" OnClick="btnDeletePerson_Click" />--%>
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
    </main>

</asp:Content>
