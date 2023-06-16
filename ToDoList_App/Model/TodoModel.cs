using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace ToDoList_App
{
    public class TodoModel
    {
        private TodoStartedRepo _todoStartedRepo;
        public List<TaskDataModel> TaskDataList { get; set; }
        private List<TaskTable> TaskTableDataList { get; set; }

        public TodoModel(TodoStartedRepo todoStartedRepo)
        {
            _todoStartedRepo = todoStartedRepo;
        }

        public async Task<Result> performAction()
        {
            TaskTableDataList = await _todoStartedRepo.GetAllTasks();
            if (TaskTableDataList.Count != 0)
            {
                FillData();
                return new Result
                {
                    IsSuccess = true,
                    Message = "Fetched from database"
                };
            }

            SetupData();
            var res = await _todoStartedRepo.StoreAllTasks(TaskTableDataList);
            if (res)
                return new Result
                {
                    IsSuccess = true,
                    Message = " data created and stored"
                };
            else
                return new Result
                {
                    IsSuccess = false,
                    Message = "Something went wrong"
                };
        }

        private void FillData()
        {
            TaskDataList = new List<TaskDataModel>();
            foreach (var task in TaskTableDataList)
            {
                var tdm = new TaskDataModel()
                {
                    TaskDescription = task.TaskDescription,
                    TaskName = task.TaskName,
                    TaskDate = task.CreatedDate,
                };
                TaskDataList.Add(tdm);
            }
        }

        private void SetupData()
        {
            TaskDataList = new List<TaskDataModel>();
            TaskDataList.Add(new TaskDataModel
            {
                ImageSource = "undone",
                TaskDescription = "This is the task you will perform at this time",
                TaskName = "Task 1",
                IsDone = false,
                TaskDate = DateTime.Now,
            });
            TaskDataList.Add(new TaskDataModel
            {
                ImageSource = "undone",
                TaskDescription = "This is the task you will perform at this time",
                TaskName = "Task 2",
                IsDone = false,
                TaskDate = DateTime.Now,
            });
            TaskDataList.Add(new TaskDataModel
            {
                ImageSource = "undone",
                TaskDescription = "This is the task you will perform at this time",
                TaskName = "Task 3",
                IsDone = false,
                TaskDate = DateTime.Now,
            });
            TaskDataList.Add(new TaskDataModel
            {
                ImageSource = "undone",
                TaskDescription = "This is the task you will perform at this time",
                TaskName = "Task 4",
                IsDone = false,
                TaskDate = DateTime.Now,
            });
            TaskDataList.Add(new TaskDataModel
            {
                ImageSource = "undone",
                TaskDescription = "This is the task you will perform at this time",
                TaskName = "Task 5",
                IsDone = false,
                TaskDate = DateTime.Now,
            });
            TaskDataList.Add(new TaskDataModel
            {
                ImageSource = "undone",
                TaskDescription = "This is the task you will perform at this time",
                TaskName = "Task 6",
                IsDone = false,
                TaskDate = DateTime.Now,
            });
            TaskDataList.Add(new TaskDataModel
            {
                ImageSource = "undone",
                TaskDescription = "This is the task you will perform at this time",
                TaskName = "Task 7",
                IsDone = false,
                TaskDate = DateTime.Now,
            });
            TaskDataList.Add(new TaskDataModel
            {
                ImageSource = "undone",
                TaskDescription = "This is the task you will perform at this time",
                TaskName = "Task 8",
                IsDone = false,
                TaskDate = DateTime.Now,
            });
            TaskDataList.Add(new TaskDataModel
            {
                ImageSource = "undone",
                TaskDescription = "This is the task you will perform at this time",
                TaskName = "Task 9",
                IsDone = false,
                TaskDate = DateTime.Now,
            });
            TaskDataList.Add(new TaskDataModel
            {
                ImageSource = "undone",
                TaskDescription = "This is the task you will perform at this time",
                TaskName = "Task 10",
                IsDone = false,
                TaskDate = DateTime.Now,
            });
            foreach (var item in TaskDataList)
            {
                var tasktable = new TaskTable();
                tasktable.CreatedDate = item.TaskDate;
                tasktable.TaskName = item.TaskName;
                tasktable.TaskDescription = item.TaskDescription;
                TaskTableDataList.Add(tasktable);
            }
        }
    }
}