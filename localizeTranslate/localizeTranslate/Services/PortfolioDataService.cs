using System.Globalization;

namespace localizeTranslate.Services;

public class PortfolioDataService : IPortfolioDataService
{
    private string CurrentCulture => CultureInfo.CurrentUICulture.TwoLetterISOLanguageName;

    public List<Job> GetJobs() => CurrentCulture switch
    {
        "th" => GetJobsTh(),
        "zh" => GetJobsZh(),
        "ja" => GetJobsJa(),
        "ko" => GetJobsKo(),
        _ => GetJobsEn()
    };

    public List<Project> GetProjects() => CurrentCulture switch
    {
        "th" => GetProjectsTh(),
        "zh" => GetProjectsZh(),
        "ja" => GetProjectsJa(),
        "ko" => GetProjectsKo(),
        _ => GetProjectsEn()
    };

    public List<SkillCategory> GetSkills() => CurrentCulture switch
    {
        "th" => GetSkillsTh(),
        "zh" => GetSkillsZh(),
        "ja" => GetSkillsJa(),
        "ko" => GetSkillsKo(),
        _ => GetSkillsEn()
    };

    public List<EducationItem> GetEducation() => CurrentCulture switch
    {
        "th" => GetEducationTh(),
        "zh" => GetEducationZh(),
        "ja" => GetEducationJa(),
        "ko" => GetEducationKo(),
        _ => GetEducationEn()
    };

    // ===== English =====
    private static List<Job> GetJobsEn() => new()
    {
        new Job
        {
            Title = "Administrative Officer",
            Company = "Rattanakit Farm",
            Period = "2023-2025",
            Details = new() { "Utilized Microsoft Excel for data management and reporting", "Oversaw implementation of farm management system" }
        },
        new Job
        {
            Title = "Outsource Full Stack Developer",
            Company = "Soft Inter Chiangmai",
            Period = "2022-2023",
            Details = new() { "Developed ERP system with SSRS reporting", "Built using Angular and C# .NET" }
        }
    };

    private static List<Project> GetProjectsEn() => new()
    {
        new Project { Title = "Bootcamp Project", Year = "2025", Description = "Multiple projects including E-Commerce web application" }
    };

    private static List<SkillCategory> GetSkillsEn() => new()
    {
        new SkillCategory { Name = "Tech Skills", Items = new() { "HTML", "CSS", "JavaScript", "React", "Angular", "C#" } },
        new SkillCategory { Name = "Databases", Items = new() { "MongoDB" } }
    };

    private static List<EducationItem> GetEducationEn() => new()
    {
        new EducationItem { Degree = "Bachelor's Degree in Computer Science", School = "Naresuan University", Period = "2019-2022" }
    };

    // ===== Thai =====
    private static List<Job> GetJobsTh() => new()
    {
        new Job
        {
            Title = "เจ้าหน้าที่ธุรการ",
            Company = "รัตนกิจฟาร์ม",
            Period = "2566-2568",
            Details = new() { "ใช้ Microsoft Excel ในการจัดการข้อมูลและจัดทำรายงาน", "ดูแลการนำระบบจัดการฟาร์มมาใช้งาน" }
        },
        new Job
        {
            Title = "นักพัฒนา Full Stack (Outsource)",
            Company = "ซอฟต์ อินเตอร์ เชียงใหม่",
            Period = "2565-2566",
            Details = new() { "พัฒนาระบบ ERP พร้อมระบบรายงาน SSRS", "สร้างด้วย Angular และ C# .NET" }
        }
    };

    private static List<Project> GetProjectsTh() => new()
    {
        new Project { Title = "โปรเจค Bootcamp", Year = "2568", Description = "หลายโปรเจครวมถึงเว็บแอปพลิเคชัน E-Commerce" }
    };

    private static List<SkillCategory> GetSkillsTh() => new()
    {
        new SkillCategory { Name = "ทักษะด้านเทคนิค", Items = new() { "HTML", "CSS", "JavaScript", "React", "Angular", "C#" } },
        new SkillCategory { Name = "ฐานข้อมูล", Items = new() { "MongoDB" } }
    };

    private static List<EducationItem> GetEducationTh() => new()
    {
        new EducationItem { Degree = "ปริญญาตรี สาขาวิทยาการคอมพิวเตอร์", School = "มหาวิทยาลัยนเรศวร", Period = "2562-2565" }
    };

    // ===== Chinese =====
    private static List<Job> GetJobsZh() => new()
    {
        new Job
        {
            Title = "行政专员",
            Company = "Rattanakit Farm",
            Period = "2023-2025",
            Details = new() { "使用Microsoft Excel进行数据管理和报告", "监督农场管理系统的实施" }
        },
        new Job
        {
            Title = "外包全栈开发工程师",
            Company = "Soft Inter Chiangmai",
            Period = "2022-2023",
            Details = new() { "开发带有SSRS报告的ERP系统", "使用Angular和C# .NET构建" }
        }
    };

    private static List<Project> GetProjectsZh() => new()
    {
        new Project { Title = "训练营项目", Year = "2025", Description = "多个项目，包括电子商务网站应用" }
    };

    private static List<SkillCategory> GetSkillsZh() => new()
    {
        new SkillCategory { Name = "技术技能", Items = new() { "HTML", "CSS", "JavaScript", "React", "Angular", "C#" } },
        new SkillCategory { Name = "数据库", Items = new() { "MongoDB" } }
    };

    private static List<EducationItem> GetEducationZh() => new()
    {
        new EducationItem { Degree = "计算机科学学士学位", School = "纳黎萱大学", Period = "2019-2022" }
    };

    // ===== Japanese =====
    private static List<Job> GetJobsJa() => new()
    {
        new Job
        {
            Title = "事務担当者",
            Company = "Rattanakit Farm",
            Period = "2023-2025",
            Details = new() { "Microsoft Excelを使用したデータ管理とレポート作成", "農場管理システムの導入を監督" }
        },
        new Job
        {
            Title = "外部委託フルスタック開発者",
            Company = "Soft Inter Chiangmai",
            Period = "2022-2023",
            Details = new() { "SSRSレポート付きERPシステムを開発", "AngularとC# .NETで構築" }
        }
    };

    private static List<Project> GetProjectsJa() => new()
    {
        new Project { Title = "ブートキャンププロジェクト", Year = "2025", Description = "Eコマースウェブアプリケーションを含む複数のプロジェクト" }
    };

    private static List<SkillCategory> GetSkillsJa() => new()
    {
        new SkillCategory { Name = "技術スキル", Items = new() { "HTML", "CSS", "JavaScript", "React", "Angular", "C#" } },
        new SkillCategory { Name = "データベース", Items = new() { "MongoDB" } }
    };

    private static List<EducationItem> GetEducationJa() => new()
    {
        new EducationItem { Degree = "コンピュータサイエンス学士号", School = "ナレースワン大学", Period = "2019-2022" }
    };

    // ===== Korean =====
    private static List<Job> GetJobsKo() => new()
    {
        new Job
        {
            Title = "행정 담당자",
            Company = "Rattanakit Farm",
            Period = "2023-2025",
            Details = new() { "Microsoft Excel을 활용한 데이터 관리 및 보고", "농장 관리 시스템 구현 감독" }
        },
        new Job
        {
            Title = "외주 풀스택 개발자",
            Company = "Soft Inter Chiangmai",
            Period = "2022-2023",
            Details = new() { "SSRS 보고 기능이 포함된 ERP 시스템 개발", "Angular와 C# .NET으로 구축" }
        }
    };

    private static List<Project> GetProjectsKo() => new()
    {
        new Project { Title = "부트캠프 프로젝트", Year = "2025", Description = "전자상거래 웹 애플리케이션을 포함한 다수의 프로젝트" }
    };

    private static List<SkillCategory> GetSkillsKo() => new()
    {
        new SkillCategory { Name = "기술 스킬", Items = new() { "HTML", "CSS", "JavaScript", "React", "Angular", "C#" } },
        new SkillCategory { Name = "데이터베이스", Items = new() { "MongoDB" } }
    };

    private static List<EducationItem> GetEducationKo() => new()
    {
        new EducationItem { Degree = "컴퓨터 과학 학사", School = "나레수안 대학교", Period = "2019-2022" }
    };
}
