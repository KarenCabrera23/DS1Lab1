﻿<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>DeleteVideo</title>
</head>
<body>
     <form action = "Video/DeleteVideo" method=post>
    <fieldset>
    <legend>Ingresa el IdVideo que se va a eliminar</legend>
    <label for="idVideo">IdVideo</label>
    <input type="text" name="IdVideo" />
    <h1></h1>
    <input type="submit" value= "Eliminar Video"/>
    </fieldset>
    </form>
     
</body>
</html>
