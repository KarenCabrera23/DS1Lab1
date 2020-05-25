<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>AddVideo</title>
</head>
<body>
   <h1>Agrega tu Video</h1>
    <form action="/Video/AddVideo" method =post>
    <fieldset>
    <legend>Ingresa los datos</legend>
    <label for="idVideo">IdVideo</label>
    <input type="text" name="IdVideo" />

    <label for="Titulo">Titulo</label>
    <input type="text" name="Titulo" />

    <label for="Repro">Repro</label>
    <input type="text" name="Repro" />

    <label for="Repro">Url</label>
    <input type="text" name="Url" />

    <input type ="submit" value="Agregar Video"/>
    </form>
</body>
</html>
