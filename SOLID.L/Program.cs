using SOLID.L;

Impresora impresora = new Impresora();

Remito remito = new Remito(DateTime.Now, 64858, 10);
Factura factura = new Factura(DateTime.Now, 35735);
NotaCredito notaCredito = new NotaCredito(DateTime.Now, 77575);

impresora.ImprimirRemito(remito);
impresora.ImprimirFactura(factura);
impresora.ImprimirNotaCredito(notaCredito);

Console.ReadKey();