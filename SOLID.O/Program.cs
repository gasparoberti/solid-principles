using SOLID.O;

//DocumentoContable factura = new DocumentoContable(TipoDocumentoContable.Factura, 12365);
//DocumentoContable notacredito = new DocumentoContable(TipoDocumentoContable.NotaCredito, 12365);
//Console.WriteLine(factura.Descripcion());
//Console.WriteLine(notacredito.Descripcion());

DocumentoContable factura = new Factura(12356);
Console.WriteLine(factura.Descripcion());
DocumentoContable notadebito = new NotaDebito(12356);
Console.WriteLine(notadebito.Descripcion());
Console.ReadKey();

