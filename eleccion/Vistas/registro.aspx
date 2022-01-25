<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="registro.aspx.cs" Inherits="eleccion.Vistas.registro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet"/>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js" ></script>
    <script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
    <link href="Styles/Registro.css" rel="stylesheet" />

    <title>Registro</title>
</head>
<body class="form-control bg-light" >

    <div class="wrapper" >
        <div class="row" >
            <h2 class="text-center"> Registro de usuario </h2>
            <div class="col">

                 <form id="formulario_registr" class="form-check"  runat="server">
             <div class="formcontent">
             <fieldset>
                      
                    <div>
                    <asp:Label ID="LabelDucumento" runat="server" Text="Numero de ducumento"></asp:Label>
                    <asp:TextBox ID="TextDocumento" CssClass="form-control"  runat="server"  placeholder="Numero documento" OnTextChanged="TextDocumento_TextChanged" ></asp:TextBox> 
                    </div>
               
                    <div>
                    <asp:Label ID="Labelnombre1" runat="server" Text="Primer nombre"></asp:Label>
                    <asp:TextBox ID="Textnombre1" CssClass="form-control"  runat="server" placeholder="Primer nombre" ></asp:TextBox>

                    </div> 

                     
                    <div>
                    <asp:Label ID="Labelnombre2" runat="server" Text="Segundo nombre"></asp:Label>
                    <asp:TextBox ID="TextBox1" CssClass="form-control"  runat="server" placeholder="Segundo nombre" ></asp:TextBox>
                    </div>

                     

              
                  <div>
                    <asp:Label ID="LabelApellido1" runat="server" Text="Primer apellido"></asp:Label>
                    <asp:TextBox ID="Textapellido1" CssClass="form-control"  runat="server" placeholder="Primer apellido" ></asp:TextBox>

                       </div>
                 <div>
                    <asp:Label ID="Labelapellido2" runat="server" Text="Segundo apellido"></asp:Label>
                    <asp:TextBox ID="Textapellido2"  CssClass="form-control" runat="server" placeholder="Segundo apellido" ></asp:TextBox>
                 </div>

                 

                 <div>
                    <asp:Label ID="LabelUsuario" runat="server" Text="Usuario"></asp:Label>
                    <asp:TextBox ID="TextUsuario"  CssClass="form-control" runat="server" placeholder="Usuario" ></asp:TextBox>
                 </div>

                 <div>
                    <asp:Label ID="Labelpassword" runat="server" Text="Contraseña"></asp:Label>
                    <asp:TextBox ID="Textpassword"  CssClass="form-control" type="password" runat="server" placeholder="Contraseña" ></asp:TextBox>
                 </div>

                 <div>
                     <asp:Label ID="LabelConpassword" runat="server" Text="Confirmar Contraseña"></asp:Label>
                     <asp:TextBox ID="TextCon_password" type="password" CssClass="form-control" runat="server" placeholder="Confirmar Contraseña" ></asp:TextBox>
                 </div>

                 <div>
                    <asp:Label ID="Labeltelefono" runat="server" Text="Telefono"></asp:Label>
                    <asp:TextBox ID="TextTelefono" CssClass="form-control" runat="server" placeholder="Telefono" ></asp:TextBox>

                 </div>
                   
                 <div>
                 <asp:Label ID="Labelgenero" runat="server" Text="Genero"></asp:Label>
                 </div>
                  

                 <div>
            <asp:DropDownList ID="DropDownListGenero" runat="server">
                  <asp:ListItem Value="0"> Seleccione </asp:ListItem>
                  <asp:ListItem Value="1"> Masculino </asp:ListItem>
                  <asp:ListItem Value="2"> Femenino </asp:ListItem>
                  <asp:ListItem Value="3"> Otro </asp:ListItem>
            </asp:DropDownList>

                 </div>


                 <div>
                     <asp:Label ID="Labelrol" runat="server" Text="Rol"></asp:Label>
                 </div>

                 <div>
                     

            <asp:DropDownList ID="DropDownListRol" runat="server">
                  <asp:ListItem Value="0"> Seleccione </asp:ListItem>
                  <asp:ListItem Value="1"> Docente </asp:ListItem>
                  <asp:ListItem Value="2"> Estudiante </asp:ListItem>
                  <asp:ListItem Value="3">Administardor </asp:ListItem>
            </asp:DropDownList>
                 </div>



                 <div>
                     <asp:Label ID="LabelDocumento" runat="server" Text="Tipo Documento"></asp:Label>
                 </div>         
                 <div>
 
            <asp:DropDownList ID="DropDownListTipoDocu" runat="server">
                  <asp:ListItem Value="0"> Seleccione </asp:ListItem>
                  <asp:ListItem Value="1"> Cedula </asp:ListItem>
                  <asp:ListItem Value="2"> Tarjeta de identidad </asp:ListItem>
                  
            </asp:DropDownList>
                     

                 </div>



             </fieldset>
             
         
             <hr />
             <div class="row">
                 <asp:Button ID="ButRegistro" runat="server" Text="Registrar" CssClass="btn btn-dark btn-primary" OnClick="ButRegistro_Click" />
                 <div>
                     <hr />
                     <a href="login.aspx" class="he2"><p>Atras, <a class="link" href="login.aspx">Iniciar Sesion </a></p>
                 </div>
             </div>     

            </div>
                </form>

            </div>
        </div>
    </div>




</body>
</html>
