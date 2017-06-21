using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDSfonacotDatos
{
    public class Globales
    {
        public static GDSfonacotDatos.DTO.DatosUsuario objpasardatosusuario = new GDSfonacotDatos.DTO.DatosUsuario();
        public static string serverbd = "sql5031.smarterasp.net";
        public static string basename = "DB_9F97CF_GDSFnt";
        public static string userbd = "DB_9F97CF_GDSFnt_admin";
        public static string pass = "GDSFonacot07.";
    }
}<DirectedGraph xmlns="http://schemas.microsoft.com/vs/2009/dgml">
  <Nodes>
    <Node Id="(@1 @2)" Visibility="Hidden" />
    <Node Id="(@3 Namespace=GDSfonacotDatos Type=Globales)" Category="CodeSchema_Class" CodeSchemaProperty_IsPublic="True" CommonLabel="Globales" Icon="Microsoft.VisualStudio.Class.Public" IsDragSource="True" Label="Globales" SourceLocation="(Assembly=file:///C:/Users/jesus.sanchez/Desktop/Infonacot/GDSfonacotDatos/Globales.cs StartLineNumber=8 StartCharacterOffset=17 EndLineNumber=8 EndCharacterOffset=25)" />
  </Nodes>
  <Links>
    <Link Source="(@1 @2)" Target="(@3 Namespace=GDSfonacotDatos Type=Globales)" Category="Contains" />
  </Links>
  <Categories>
    <Category Id="CodeSchema_Class" Label="Clase" BasedOn="CodeSchema_Type" Icon="CodeSchema_Class" />
    <Category Id="CodeSchema_Type" Label="Tipo" Icon="CodeSchema_Class" />
    <Category Id="Contains" Label="Contiene" Description="Indica si el origen del vínculo contiene el objeto de destino." IsContainment="True" />
  </Categories>
  <Properties>
    <Property Id="CodeSchemaProperty_IsPublic" Label="Público" Description="Marca para indicar que el ámbito es Public." DataType="System.Boolean" />
    <Property Id="CommonLabel" DataType="System.String" />
    <Property Id="Icon" Label="Icono" DataType="System.String" />
    <Property Id="IsContainment" DataType="System.Boolean" />
    <Property Id="IsDragSource" Label="IsDragSource" Description="IsDragSource" DataType="System.Boolean" />
    <Property Id="Label" Label="Etiqueta" Description="Etiqueta Displayable de un objeto Annotatable." DataType="System.String" />
    <Property Id="SourceLocation" Label="Número de línea de inicio" DataType="Microsoft.VisualStudio.GraphModel.CodeSchema.SourceLocation" />
    <Property Id="Visibility" Label="Visibilidad" Description="Define si un nodo del gráfico está visible o no." DataType="System.Windows.Visibility" />
  </Properties>
  <QualifiedNames>
    <Name Id="Assembly" Label="Ensamblado" ValueType="Uri" />
    <Name Id="File" Label="Archivo" ValueType="Uri" />
    <Name Id="Namespace" Label="Espacio de nombres" ValueType="System.String" />
    <Name Id="Type" Label="Tipo" ValueType="System.Object" />
  </QualifiedNames>
  <IdentifierAliases>
    <Alias n="1" Uri="Assembly=$(VsSolutionUri)/GDSfonacotDatos/GDSfonacotDatos.csproj" />
    <Alias n="2" Uri="File=$(VsSolutionUri)/GDSfonacotDatos/Globales.cs" />
    <Alias n="3" Uri="Assembly=$(ed3d5c64-801b-4407-9222-ea8639cbbf9b.OutputPathUri)" />
  </IdentifierAliases>
  <Paths>
    <Path Id="ed3d5c64-801b-4407-9222-ea8639cbbf9b.OutputPathUri" Value="file:///C:/Users/jesus.sanchez/Desktop/Infonacot/GDSfonacotDatos/bin/Debug/GDSfonacotDatos.dll" />
    <Path Id="VsSolutionUri" Value="file:///C:/Users/jesus.sanchez/Desktop/Infonacot" />
  </Paths>
</DirectedGraph>
