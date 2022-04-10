<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication3._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

 

    <div class="row">
        <div class="col-xs-6">
           
            Listado de doctores<br />
           
            <asp:ListBox ID="ListBox3" AutoPostBack="True" runat="server" Height="262px" Width="403px" OnSelectedIndexChanged="ListBox3_SelectedIndexChanged"></asp:ListBox>
            <br />
        </div>
        <div class="col-xs-6 ">
            Listado Pacientes<br />
            <asp:ListBox ID="ListBox2" runat="server" Height="263px" Width="396px" ></asp:ListBox>
            <br />
            <asp:Button ID="Button2" runat="server" Text="Eliminar " />
            <asp:Button ID="Button3" runat="server" Text="Modificar" />
        </div>
         <div class="col-xs-6">
           
            Nuevo Medico<br />
           
             Nombre
             <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
             <br />
             Edad
             <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
             <br />
             Especialidad
             <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Añadir Medico" Width="245px" />
        </div>
        <div class="col-xs-6">
           
            Nuevo Paciente<br />
           
             Nombre
             <asp:TextBox ID="TextBox4" runat="server" Enabled="False" ></asp:TextBox>
             <br />
             Edad
             <asp:TextBox ID="TextBox5" runat="server" Enabled="False"></asp:TextBox>
             <br />
             
            <br />
            <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Añadir Paciente" Width="245px" Enabled="False" />
        </div>
       
    </div>

</asp:Content>
