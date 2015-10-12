Option Explicit
Dim http : Set http = CreateObject( "MSXML2.ServerXmlHttp" )
http.Open "GET", "http://icanhazip.com", False
http.Send
Wscript.Echo http.responseText   'or do whatever you want with it
Set http = Nothing