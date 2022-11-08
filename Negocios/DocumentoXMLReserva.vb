Imports System.Xml
Imports Modelos
Public Class DocumentoXMLReserva

    Sub CreaDocumentoXML(usuarioReservasExportar As mdUsuario, URL As String)

        Try

            Dim config As New XmlWriterSettings()
            config.Indent = True

            Using writer As XmlWriter = XmlWriter.Create(URL, config)

                writer.WriteStartDocument()
                writer.WriteStartElement("Reservas") 'Raiz

                writer.WriteStartElement("Encabezado")
                writer.WriteElementString("Identificacion", usuarioReservasExportar.Identificacion)
                writer.WriteElementString("Nombre", usuarioReservasExportar.Nombre)
                writer.WriteElementString("Apellido1", usuarioReservasExportar.Apellido1)
                writer.WriteElementString("Apellido2", usuarioReservasExportar.Apellido2)
                writer.WriteElementString("Genero", usuarioReservasExportar.Genero)
                writer.WriteElementString("Nacionalidad", usuarioReservasExportar.Nacionalidad)
                writer.WriteElementString("FechadeNacimiento", usuarioReservasExportar.FechaNacimiento)
                writer.WriteElementString("Usuario", usuarioReservasExportar.Usuario)
                writer.WriteEndElement()

                writer.WriteStartElement("Cuerpo")

                If usuarioReservasExportar.listReservas.Count > 0 Then
                    For Each res As mdReservaExportar In usuarioReservasExportar.listReservas
                        writer.WriteStartElement("Reserva")
                        writer.WriteElementString("PaisOrigen", res.PaisOrigen)
                        writer.WriteElementString("PaisDestino", res.PaisDestino)
                        writer.WriteElementString("AeropuertoOrigen", res.AeropuertoOrigen)
                        writer.WriteElementString("AeropuertoDestino", res.AeropuertoDestino)
                        writer.WriteElementString("InformacionDelVuelo", res.InformacionDelVuelo.Trim)
                        writer.WriteEndElement()
                    Next
                End If
                writer.WriteEndElement()
                writer.WriteEndElement()
                writer.WriteEndDocument()
            End Using

        Catch ex As Exception

        End Try
    End Sub

End Class
