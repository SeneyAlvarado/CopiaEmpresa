Public Class ReporteFacturacionTO
    Public Property Consecutivo As Integer
    Public Property Cliente As ClienteTO
    Public Property Historico As List(Of FacturaTO)
    Public Property Total As Double
End Class
