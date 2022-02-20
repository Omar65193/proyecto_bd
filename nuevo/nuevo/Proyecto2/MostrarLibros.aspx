<%@ Page Title="Contact" Language="C#" AutoEventWireup="true" CodeBehind="MostrarLibros.aspx.cs" Inherits="Proyecto2.Contact" %>


<!DOCTYPE html>
<html lang="en">
<head>
	<meta charset="UTF-8">
	<meta name="viewport" content="width=device-width, initial-scale=1.0">
	<title>Libros</title>
	<link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous">
    <link href="style.css" rel="stylesheet" type="text/css">
</head>
<body>
	<nav class="navbar navbar-expand-lg navbar-light bg-light fixed-top">
  		<div class="container">
    		BIBLIOTECA - LIBROS
    		<button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
    		</button>
    		<div class="collapse navbar-collapse" id="navbarSupportedContent">
                <ul>
                   <li class ="log">
      					&nbsp;</li>
              </ul>
    		</div>
  		</div>
	</nav>
    <br />
    <br />
    <br />
    <div class="container">
        <form id="form1" runat="server">
            <div class="auto-style1">
                <center>
                    <div class="auto-style1">
                Libros eLibros en Existencia<br />
                        <br />
                    </div>
                    <div class="auto-style1">
                        <br />
                        <asp:Panel ID="Panel1" runat="server">
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:Button ID="add_libro" runat="server" Text="Agregar" BackColor="#66FF33" BorderStyle="Outset" Height="56px" OnClick="add_libro_Click" Width="178px" />
                        </asp:Panel>
                        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager> 
                        <asp:Button ID="btnMostrar" runat="server" Height="55px" OnClick="btnMostrar_Click" Text="Mostrar" Width="186px" BackColor="Blue" BorderColor="Blue" />
                        <asp:UpdatePanel ID="UpdatePanel1" UpdateMode="Conditional" runat="server">
                            <ContentTemplate>
                        <asp:GridView ID="gvLibros" runat="server" AutoGenerateColumns="false" Width="1414px">
                            <Columns>
                                <asp:BoundField HeaderText="ID" DataField="ID" >
                                <HeaderStyle Font-Size="12pt" Width="100px" />
                                <ItemStyle Font-Size="10pt" />
                                </asp:BoundField>
                                <asp:BoundField HeaderText="ISBN" DataField="ISBN" >
                                    <HeaderStyle Font-Size="12pt" Width="100px" />
                                <ItemStyle Font-Size="10pt" />
                                </asp:BoundField>
                                <asp:BoundField HeaderText="NO_EDICION" DataField="NO_EDICION" >
                                    <HeaderStyle Font-Size="12pt" Width="150px" />
                                <ItemStyle Font-Size="10pt" />
                                </asp:BoundField>
                                <asp:BoundField HeaderText="ANIO_PUBLICACION" DataField="ANIO_PUBLICACION" >
                                    <HeaderStyle Font-Size="12pt" Width="200px" />
                                <ItemStyle Font-Size="10pt" />
                                </asp:BoundField>
                                <asp:BoundField HeaderText="NOMBRES_AUTORES" DataField="NOMBRES_AUTORES" >
                                    <HeaderStyle Font-Size="12pt" Width="100px" />
                                <ItemStyle Font-Size="10pt" />
                                </asp:BoundField>
                                <asp:BoundField HeaderText="PAIS" DataField="PAIS" >
                                    <HeaderStyle Font-Size="12pt" Width="100px" />
                                <ItemStyle Font-Size="10pt" />
                                </asp:BoundField>
                                <asp:BoundField HeaderText="SINOPSIS" DataField="SINOPSIS" >
                                    <HeaderStyle Font-Size="12pt" Width="300px" />
                                <ItemStyle Font-Size="10pt" />
                                </asp:BoundField>
                                <asp:BoundField HeaderText="CARRERA" DataField="CARRERA" >
                                    <HeaderStyle Font-Size="12pt" Width="100px" />
                                <ItemStyle Font-Size="10pt" />
                                </asp:BoundField>
                                <asp:BoundField HeaderText="MATERIA" DataField="MATERIA" >
                                    <HeaderStyle Font-Size="12pt" Width="100px" />
                                <ItemStyle Font-Size="10pt" />
                                </asp:BoundField>

                            </Columns>
                        </asp:GridView>
                              </ContentTemplate>
                            </asp:UpdatePanel>
                        <br />
                        <br />
                    </div>
                </center>
            </div>
        </form>
	</div>
    <br />
    <br />
    <br />
    <br />
    <footer>
        <p>&copy; >&copy; <%: DateTime.Now.Year %>- Libreria</p>
    </footer>
	<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-ka7Sk0Gln4gmtz2MlQnikT1wXgYsOg+OMhuP+IlRH9sENBO0LRn5q+8nbTov4+1p" crossorigin="anonymous"></script>
</body>
</html>