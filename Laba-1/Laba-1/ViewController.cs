using System;
using AppKit;
using Foundation;

namespace Laba1
{
    public partial class ViewController : NSViewController
    {
        // Данные для таблицы
        private NSMutableArray tableData;


        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Инициализация данных для таблицы
            tableData = new NSMutableArray
            {
                new NSString("Пример строки 1"),
                new NSString("Пример строки 2")
            };


            TAb = new NSTableView
            {
                DataSource = new TableDataSource(tableData),
                Delegate = new TableDelegate(this)
            };


            DeleteBtn = new NSButton();
            // Изначально кнопка удаления отключена
            if (DeleteBtn != null)
            {
                DeleteBtn.Enabled = false;
            }
            else
            {
                Console.WriteLine("DeleteBtn is not initialized.");
            }
        }

        // Метод, вызываемый при нажатии на кнопку "AddButton"
        partial void AddButton(NSObject sender)
        {
            if (TAb != null && tableData != null)
            {
                // Добавляем новую строку в таблицу
                tableData.Add(new NSString("Новая строка"));
                TAb.SetValueForKey(tableData.GetItem(index));
                TAb.ReloadData();  
            }
            else
            {
                Console.WriteLine("TAb or tableData is not initialized.");
            }
        }

        // Метод, вызываемый при нажатии на кнопку "DeleteButton"
        partial void DeleteButton(NSObject sender)
        {
            if (TAb == null)
            {
                Console.WriteLine("TAb is not initialized.");
                return;
            }

            if (tableData == null)
            {
                Console.WriteLine("tableData is not initialized.");
                return;
            }

            int selectedRow = (int)TAb.SelectedRow;
            if (selectedRow >= 0)
            {

                tableData.RemoveLastObject();
     
            }

            // Отключаем кнопку удаления, если ничего не выбрано
            DeleteBtn.Enabled = TAb.SelectedRow >= 0;
        }

        // Метод для активации кнопки удаления при выборе строки
        public void UpdateDeleteButtonState()
        {
            if (DeleteBtn != null && TAb != null)
            {
                DeleteBtn.Enabled = TAb.SelectedRow >= 0; // Включаем кнопку, если строка выбрана
            }
        }
    }

    // Источник данных для NSTableView
    public class TableDataSource : NSTableViewDataSource
    {
        private NSMutableArray data;

        public TableDataSource(NSMutableArray data)
        {
            this.data = data;
        }

        // Метод для возврата количества строк в таблице
        public override nint GetRowCount(NSTableView tableView)
        {
            return (nint)data.Count;
        }

        // Метод для получения данных для конкретной строки
        public override NSObject GetObjectValue(NSTableView tableView, NSTableColumn tableColumn, nint row)
        {
            return data.GetItem<NSString>((nuint)row);
        }
    }

    // Делегат для NSTableView
    public class TableDelegate : NSTableViewDelegate
    {
        private ViewController controller;

        public TableDelegate(ViewController controller)
        {
            this.controller = controller;
        }

        // Метод вызывается при изменении выбора строки
        public override void SelectionDidChange(NSNotification notification)
        {
            // Обновляем состояние кнопки удаления
            controller.UpdateDeleteButtonState();
        }
    }
}