namespace SCSIMS.Services;

public class FilterService : IFilterService, IService
{
    public FilterService()
    {
    }

    // Properties
    public string? FirstName { private get; set; }
    public string? Midname { private get; set; }
    public string? LastName { private get; set; }
    public string? ExtName { private get; set; }
    public string? Course { private get; set; }
    public string? Gender { get; set; }
    public byte? YearLevel { private get; set; }
    public string? Date { private get; set; }

    public IEnumerable<StudentsDataViewModel>? FilterNow(IEnumerable<StudentsDataViewModel>? toFilter)
    {
        IEnumerable<StudentsDataViewModel>? resTempData = new List<StudentsDataViewModel>();
        bool firstIsDone = false;

        if (toFilter != null && toFilter.Any())
        {
            if (!string.IsNullOrWhiteSpace(FirstName))
            {
                resTempData = toFilter.Where(d => d.FName!.ToLower() == FirstName.ToLower());
                firstIsDone = true;
            }

            if (!string.IsNullOrWhiteSpace(Midname))
            {
                if (!firstIsDone)
                {
                    resTempData = toFilter.Where(d => d.MName!.ToLower() == Midname.ToLower());
                    firstIsDone = true;
                }
                else
                {
                    resTempData = resTempData.Where(d => d.MName!.ToLower() == Midname.ToLower());
                }
            }

            if (!string.IsNullOrWhiteSpace(LastName))
            {
                if (!firstIsDone)
                {
                    resTempData = toFilter.Where(d => d.LName!.ToLower() == LastName.ToLower());
                    firstIsDone = true;
                }
                else
                {
                    resTempData = resTempData.Where(d => d.LName!.ToLower() == LastName.ToLower());
                }
            }

            if (!string.IsNullOrWhiteSpace(ExtName))
            {
                if (!firstIsDone)
                {
                    resTempData = toFilter.Where(d => d.EName!.ToLower() == ExtName.ToLower());
                    firstIsDone = true;
                }
                else
                {
                    resTempData = resTempData.Where(d => d.EName!.ToLower() == ExtName.ToLower());
                }
            }

            if (!string.IsNullOrWhiteSpace(Course))
            {
                if (!firstIsDone)
                {
                    resTempData = toFilter.Where(d => d.Course!.ToLower() == Course.ToLower());
                    firstIsDone = true;
                }
                else
                {
                    resTempData = resTempData.Where(d => d.Course!.ToLower() == Course.ToLower());
                }
            }

            if (!string.IsNullOrWhiteSpace(Gender))
            {
                if (!firstIsDone)
                {
                    resTempData = toFilter.Where(d => d.Gender!.ToLower() == Gender.ToLower());
                    firstIsDone = true;
                }
                else
                {
                    resTempData = resTempData.Where(d => d.Gender!.ToLower() == Gender.ToLower());
                }
            }

            if (YearLevel != null && YearLevel != 0)
            {
                if (!firstIsDone)
                {
                    resTempData = toFilter.Where(d => (d.YrLvl ?? 0) == YearLevel);
                    firstIsDone = true;
                }
                else
                {
                    resTempData = resTempData.Where(d => (d.YrLvl ?? 0) == YearLevel);
                }
            }

            if (!string.IsNullOrWhiteSpace(Date))
            {
                if (!firstIsDone)
                {
                    resTempData = toFilter.Where(d => d.Date!.Value.ToString("MMMM dd, yyyy") == Date);
                    firstIsDone = true;
                }
                else
                {
                    resTempData = resTempData.Where(d => d.Date!.Value.ToString("MMMM dd, yyyy") == Date);
                }
            }
        }

        if (firstIsDone)
        {
            return resTempData;
        }

        return toFilter;
    }
}
