namespace MVVMDemo
{
    public class AppState
    {
        public event Action OnChange;
        public void NotifyChanges() => OnChange?.Invoke();
    }
}
