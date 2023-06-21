//using Stimulsoft.Report;
//using Stimulsoft.Report.Web;

//public class ReportGenerator
//{
//    public static byte[] GeneratePharmacyInventoryReport()
//    {
//        // 1. Load the report template created in Stimulsoft Designer
//        StiReport report = new StiReport();
//        report.Load("Path/To/Your/ReportTemplate.mrt");

//        // 2. Fetch live data for the pharmacy inventory from your application
//        // Assuming you have retrieved the data and stored it in a DataTable called 'inventoryData'

//        // 3. Assign the data to the report's data source
//        report.RegData("PharmacyInventoryData", inventoryData);

//        // 4. Generate the report
//        report.Render();

//        // 5. Export the report to a desired format (e.g., PDF)
//        StiPdfExportSettings exportSettings = new StiPdfExportSettings();
//        StiPdfExportService exportService = new StiPdfExportService();
//        byte[] reportBytes = exportService.ExportBytes(report, exportSettings);

//        return reportBytes;
//    }
//}