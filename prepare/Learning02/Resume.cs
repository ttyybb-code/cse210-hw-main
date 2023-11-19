public class Resume
{
    public string _name = "";
    public List<Job> _jobs = new List<Job>();

    public void Show()
    {
        Console.WriteLine($"Name: {_name}");
        Console.Write("Jobs: ");

        foreach (Job job in _jobs)
        {
            job.Show();
        }
    }

}