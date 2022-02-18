using SOLID.D;

Impresora impresora = new Impresora();

Factura factura = new Factura(DateTime.Now, 554, 877897);
NotaCredito notaCredito = new NotaCredito(DateTime.Now, 3556, 53454354);
Remito remito = new Remito(86868, DateTime.Now, 7);
FacturaLuz facturaLuz = new FacturaLuz(6565, "JKUH5472");
Municipal municipal = new Municipal(45856, "65464DDfg");

impresora.Imprimir(factura);
impresora.Imprimir(notaCredito);
impresora.Imprimir(remito);
impresora.Imprimir(facturaLuz);
impresora.Imprimir(municipal);

Console.ReadKey();
