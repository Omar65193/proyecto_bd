<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="Proyecto2.Registro" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <meta charset="UTF-8">
	<meta name="viewport" content="width=device-width, initial-scale=1.0">
	<title>Login</title>
	<link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous">
    <link href="style.css" rel="stylesheet" type="text/css">
</head>
<body>
	<nav class="navbar navbar-expand-lg navbar-light bg-light fixed-top">
  		<div class="container">
    		<a class="navbar-brand" href="Inicio.aspx">PUTOS</a>
    		<button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
      			<span class="navbar-toggler-icon"></span>
    		</button>
    		<div class="collapse navbar-collapse" id="navbarSupportedContent">
                <ul>
                   <li class ="log">
      					&nbsp;</li>
              </ul>
    		</div>
  		</div>
	</nav>
    <div class ="log-form" id="reg">
            <h2>Registrar nuevo usuario</h2>
            <form id="form1" runat="server">
                <p>
                    <asp:Label ID="Label1" runat="server" Text="Usuario"></asp:Label>
                    <br />
                    <asp:TextBox ID="txtUser" runat="server" placeHolder="Ingresar Usuario"></asp:TextBox>
                </p>
                <p>
                    <asp:Label ID="Label2" runat="server"  Text="Contraseña"></asp:Label>
                    <br />
                    <asp:TextBox ID="txtPass" runat="server" TextMode ="Password" placeholder="Ingresar contraseña"></asp:TextBox>
                </p>
                <p>
                    <asp:Label ID="Label3" runat="server"  Text="Confirmar Contraseña"></asp:Label>
                    <br />
                    <asp:TextBox ID="txtPass2" runat="server" TextMode ="Password" placeholder="Ingresar contraseña de nuevo"></asp:TextBox>
                </p>
                <p>
                    <asp:Button ID="btnRegistrar" runat="server" Text="Registrar" OnClick="btnRegistrar_Click" />
                </p>
            </form>
    </div>

    <footer>
        <p>&copy; <%: DateTime.Now.Year %> - Libreria</p>
    </footer>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-ka7Sk0Gln4gmtz2MlQnikT1wXgYsOg+OMhuP+IlRH9sENBO0LRn5q+8nbTov4+1p" crossorigin="anonymous"></script>
</body>
</html>
