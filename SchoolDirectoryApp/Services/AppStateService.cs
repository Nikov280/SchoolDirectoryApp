namespace SchoolDirectoryApp.Services
{
    public class AppStateService
    {
        // Stores the IDs of schools marked as favorites.
        public HashSet<int> FavoriteSchoolIds { get; private set; } = new();

        // Event to notify components that the state has changed.
        public event Action? OnChange;

        public void ToggleFavorite(int schoolId)
        {
            if (FavoriteSchoolIds.Contains(schoolId))
            {
                FavoriteSchoolIds.Remove(schoolId);
            }
            else
            {
                FavoriteSchoolIds.Add(schoolId);
            }
            NotifyStateChanged();
        }

        public bool IsFavorite(int schoolId)
        {
            return FavoriteSchoolIds.Contains(schoolId);
        }

        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}