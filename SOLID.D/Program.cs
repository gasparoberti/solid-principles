using SOLID.D;

Impresora impresora = new Impresora();

Factura factura = new Factura(DateTime.Now, 554, 877897);
NotaCredito notaCredito = new NotaCredito(DateTime.Now, 3556, 53454354);
Remito remito = new Remito(86868, DateTime.Now, 7);
FacturaLuz facturaLuz = new FacturaLuz(6565, "JKUH5472");
Municipal municipal = new Municipal(45856, "65464DDfg");
Cobranza cobranza = new Cobranza(36544, 8889);

//como todos las clases extienden de IImprimible entonces podemos asignar una factura por ejemplo a un IImprimible e imprimirla pasando ese IImprimible
//si yo declaro los documentos como IImprimible solo podré acceder a los estados y métodos de IImprimible, es decir Imprimir. Pero si lo defino como Factura por ejemplo ahí podré acceder a todos incluido por ejemplo factura.Imprimir() o factura.Importe.
//IImprimible factura = new Factura(DateTime.Now, 554, 877897);
//IImprimible notaCredito = new NotaCredito(DateTime.Now, 3556, 53454354);
//IImprimible remito = new Remito(86868, DateTime.Now, 7);
//IImprimible facturaLuz = new FacturaLuz(6565, "JKUH5472");
//IImprimible municipal = new Municipal(45856, "65464DDfg");

//impresora.Imprimir(factura);
//impresora.Imprimir(notaCredito);
//impresora.Imprimir(remito);
//impresora.Imprimir(facturaLuz);
//impresora.Imprimir(municipal);
//impresora.Imprimir(cobranza);


List<IImprimible> lista = new List<IImprimible>();
lista.Add(factura);
lista.Add(notaCredito);
lista.Add(remito);
lista.Add(facturaLuz);
lista.Add(municipal);
lista.Add(cobranza);

foreach (var item in lista)
{
    impresora.Imprimir(item);
}

Console.ReadKey();
