﻿Imports System
Imports DbExtensions

Namespace Northwind

   <Table(Name:="EmployeeTerritories")>
   Public Class EmployeeTerritory

      <Column(IsPrimaryKey:=True)>
      Public Property EmployeeID As Integer

      <Column(IsPrimaryKey:=True)>
      Public Property TerritoryID As String

      <Association(ThisKey:=NameOf(EmployeeID))>
      Public Property Employee As Employee

      <Association(ThisKey:=NameOf(TerritoryID))>
      Public Property Territory As Territory

   End Class

End Namespace

