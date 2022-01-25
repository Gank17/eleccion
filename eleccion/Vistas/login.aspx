<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="eleccion.Vistas.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet"/>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js" ></script>
    <script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
    <link href="Styles/login.css" rel="stylesheet" />

    <title>Login</title>
</head>
<body class="bg-light" >
    <div class="wrapper">
        <div class="formcontent" >
             <form id="formulario_login" runat="server">
        <div class="from-control">
           <div class="col-md-6 text-center mb-5" >
               <asp:Label class="h2" ID="lblBienvenida" runat="server" text="Longin" ></asp:Label>
           </div>  
            <div>
                <asp:Label ID="LbUsuario" runat="server" Text="Usuario"></asp:Label>
                <asp:TextBox ID="TexUsuario" CssClass="form-control"  runat="server" placeholder="Nombre de Usuario" ></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="LbPassword" runat="server" Text="Contraseña:"></asp:Label>
                <asp:TextBox ID="TextPassword" CssClass="form-control" runat="server" type="password" placeholder="Contraseña" OnTextChanged="TextPassword_TextChanged" ></asp:TextBox>
                
            </div>

            <hr />
            <div class="row">
                <asp:Button ID="Butingresar"  CssClass="btn btn-primary btn-dark "  runat ="server" Text="Ingresar" OnClick="Butingresar_Click" />
            </div>
            <hr />
            <a href="registro.aspx" class="he2"><p>¿No tienes una cuenta? <a class="link" href="registro.aspx">Registrate </a></p>
               
        </div>
    </form>
        </div>
    </div>
   
</body>
</html>
