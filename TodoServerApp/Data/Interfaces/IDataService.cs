 // Интерфейс для описания взаимодействия данных в приложении. Используется для управления задачами и исполнителями
namespace TodoServerApp.Data.Interfaces
{
	public interface IDataService
	{
		Task<IEnumerable<TaskItem>> GetAllTasksAsync(); // получение всех задач
		Task SaveTaskAsync(TaskItem item); // сохранение новой задачи и обновление 
		Task<TaskItem> GetTaskAsync(int id); // получение конкретной задачи по id
		Task DeleteTaskAsync(int id); // удаление задачи по id
		Task<IEnumerable<PerformerItem>> GetAllPerformerAsync(); // получение всех исполнителей
		Task SavePerformerAsync(PerformerItem item); // сохранение нового исполнителя или обновление
		Task<PerformerItem> GetPerformerAsync(int id); // получение конкретного исп по id
		Task DeletePerformerAsync(int id); // удаление исп по id
	}
}
