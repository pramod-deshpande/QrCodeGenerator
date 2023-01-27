using QRCoder;
namespace QrCodeGenerator;

public static class GenerateQRCode
{
    public static string GenerateQR(string input)
    {
        QRCodeGenerator qrGenerator = new QRCodeGenerator();
        QRCodeData qrCodeData = qrGenerator.CreateQrCode(input, QRCodeGenerator.ECCLevel.Q);
        PngByteQRCode qrCode = new PngByteQRCode(qrCodeData);
        var qrCodeImage = qrCode.GetGraphic(20);
        var qrString = "data:image/png;base64," + Convert.ToBase64String(qrCodeImage.ToArray());
        return qrString;
    }
}
