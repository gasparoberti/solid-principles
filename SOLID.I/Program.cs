using SOLID.I;

Factura factura = new Factura(DateTime.Now, 38188);
factura.CAI = "63779797997";

FacturaElectronica facturaElectronica = new FacturaElectronica(DateTime.Now, 644796);
facturaElectronica.CAE = "48786968767";


facturaElectronica.Imprimir();
facturaElectronica.EnviarPorEmail();

factura.Imprimir();
factura.EnviarPorEmail();   //no puede mandar emails

Console.ReadKey();
