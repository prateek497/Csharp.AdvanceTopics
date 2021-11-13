
ReportDecorator reportDirector = new();
PDF pdfReport = new PDF();
var report = reportDirector.MakeReport(pdfReport);
report.DisplayReport();


public class Report
{
    public string ReportType { get; set; }
    public string ReportHeader { get; set; }
    public string ReportFooter { get; set; }
    public string ReportContent { get; set; }

    public void DisplayReport()
    {
        Console.WriteLine("Report Type :" + ReportType);
        Console.WriteLine("Header :" + ReportHeader);
        Console.WriteLine("Content :" + ReportContent);
        Console.WriteLine("Footer :" + ReportFooter);
    }
}

public abstract class ReportBuilder
{
    protected Report _Report { get; set; }

    public abstract void SetReportType();
    public abstract void SetReportHeader();
    public abstract void SetReportContent();
    public abstract void SetReportFooter();

    public void CreateReport()
    {
        _Report = new Report();
    }

    public Report GetReport() { return _Report; }
}
public class PDF : ReportBuilder
{
    public override void SetReportContent()
    {
        _Report.ReportContent = "Pdf Content";
    }

    public override void SetReportFooter()
    {
        _Report.ReportFooter = "Pdf Footer";
    }

    public override void SetReportHeader()
    {
        _Report.ReportHeader = "Pdf Header";
    }

    public override void SetReportType()
    {
        _Report.ReportType = "Pdf Type";
    }
}

public class Excel : ReportBuilder
{
    public override void SetReportContent()
    {
        _Report.ReportContent = "Excel Content";
    }

    public override void SetReportFooter()
    {
        _Report.ReportFooter = "Excel Footer";
    }

    public override void SetReportHeader()
    {
        _Report.ReportHeader = "Excel Header";
    }

    public override void SetReportType()
    {
        _Report.ReportType = "Excel Type";
    }
}

public class ReportDecorator
{
    public Report MakeReport(ReportBuilder reportBuilder)
    {
        reportBuilder.CreateReport();
        reportBuilder.SetReportType();
        reportBuilder.SetReportHeader();
        reportBuilder.SetReportContent();
        reportBuilder.SetReportFooter();

        return reportBuilder.GetReport();
    }
}






