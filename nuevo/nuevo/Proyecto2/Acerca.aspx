﻿<%@ Page Title="About" Language="C#"  AutoEventWireup="true" CodeBehind="Acerca.aspx.cs" Inherits="Proyecto2.About" %>


<!DOCTYPE html>
<html lang="en">
<head>
	<meta charset="UTF-8">
	<meta name="viewport" content="width=device-width, initial-scale=1.0">
	<title>Acerca</title>
	<link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous">
    <link href="style.css" rel="stylesheet" type="text/css">
</head>
<body>
	<nav class ="navbar navbar-expand-lg navbar-light bg-light fixed-top">
  		<div class="container">
    		<a class="navbar-brand" href="Inicio.aspx">PUTOS</a>
    		<button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
      			<span class="navbar-toggler-icon"></span>
    		</button>
    		<div class="collapse navbar-collapse" id="navbarSupportedContent">
      			<ul class="navbar-nav me-auto mb-2 mb-lg-0">
        			<li class="nav-item">
          				<a class="nav-link active" aria-current="page" href="Inicio.aspx">Inicio</a>
        			</li>
        			<li class="nav-item dropdown">
          				<a class="nav-link dropdown-toggle" href="#" id="navbarServicio" role="button" data-bs-toggle="dropdown" aria-expanded="false">
            			Libros
          				</a>
          				<ul class="dropdown-menu" aria-labelledby="navbarServicio">
            				<li><a class="dropdown-item" href="MostrarLibros.aspx">Mostrar Libros</a></li>
            				<li><a class="dropdown-item" href="AgregarLibro.aspx">Agregar Libro</a></li>

          				</ul>
      				</li>
      				<li>
      					<a class="nav-link active" aria-current="page" href="Acerca.aspx">Acerca de</a>
      				</li>
      			</ul>
                <ul>
                    <li class ="log">
      					<a class="nav-link active" aria-current="page" href="Login.aspx">Entrar/Registrarse</a>
      				</li>
                </ul>
    		</div>
  		</div>
	</nav>
            <footer>
                <p>&copy; <%: DateTime.Now.Year %> - Libreria</p>
            </footer>
	<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-ka7Sk0Gln4gmtz2MlQnikT1wXgYsOg+OMhuP+IlRH9sENBO0LRn5q+8nbTov4+1p" crossorigin="anonymous"></script>
</body>
</html>