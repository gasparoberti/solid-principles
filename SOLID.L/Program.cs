using SOLID.L;

Impresora impresora = new Impresora();

Remito remito = new Remito(DateTime.Now, 64858, 10);
//Factura factura = new Factura(DateTime.Now, 35735);
DocumentoContable factura = new Factura(DateTime.Now, 35735);
//NotaCredito notaCredito = new NotaCredito(DateTime.Now, 77575);
DocumentoContable notaCredito = new NotaCredito(DateTime.Now, 77575);

NotaDebito notaDebito = new NotaDebito(DateTime.Now, 33453);

impresora.ImprimirRemito(remito);
//impresora.ImprimirFactura(factura);
impresora.Imprimir(factura);
//impresora.ImprimirNotaCredito(notaCredito);
impresora.Imprimir(notaCredito);

impresora.Imprimir(notaDebito);

Console.ReadKey();