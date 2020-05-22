using MiniTC.Model;
using MiniTC.Services;
using MiniTC.ViewModel.BaseClass;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;

namespace MiniTC.ViewModel
{
    class MainViewModel: ViewModelBase
    {
        #region Fields

        private IPanelTC focusedSide;

        private IPanelTC left;
        private string currentFileLeft;

        private IPanelTC right;
        private string currentFileRight;

        #endregion

        #region Properties

        //both
        public string[] Drives
        {
            get { return left.AvaibleDrives; }
        }

        //left panel
        public string CurrentDriveLeft
        {
            set
            {
                if (value != null)
                {
                    left.getContent(value);
                    onPropertyChanged(nameof(CurrentDriveLeft), nameof(CurrentDirLeft), nameof(CurrentPathLeft));
                }
            }
        }
        public string CurrentFileLeft
        {
            set => currentFileLeft = value;
        }
        public List<string> CurrentDirLeft => left.CurrentDirectoryContent;
        public string CurrentPathLeft => left.CurrentPath;

        //right panel
        public string CurrentDriveRight
        {
            set
            {
                if (value != null)
                {
                    right.getContent(value);
                    onPropertyChanged(nameof(CurrentDriveRight), nameof(CurrentDirRight), nameof(CurrentPathRight));
                }
            }
        }
        public string CurrentFileRight
        {
            set => currentFileRight = value;
        }
        public List<string> CurrentDirRight => right.CurrentDirectoryContent;
        public string CurrentPathRight => right.CurrentPath;

        #endregion

        #region Ctor

        public MainViewModel()
        {
            focusedSide = null;

            left = new PanelTCModel();
            right = new PanelTCModel();
        }

        #endregion

        #region Commands

        //focus
        private ICommand focusLeftPanel = null;
        public ICommand FocusLeftPanel
        {
            get
            {
                if (focusedSide == null)
                {
                    focusLeftPanel = new RelayCommand(x => focusedSide = left, x => true);
                }
                return focusLeftPanel;
            }
        }

        private ICommand focusRightPanel = null;
        public ICommand FocusRightPanel
        {
            get
            {
                if (focusedSide == null)
                {
                    focusRightPanel = new RelayCommand(x => focusedSide = right, x => true);
                }
                return focusRightPanel;
            }
        }

        //change dir
        private ICommand goToDirectoryLeft = null;
        public ICommand GoToDirectoryLeft
        {
            get
            {
                if (goToDirectoryLeft == null)
                {
                    goToDirectoryLeft = new RelayCommand(
                                                            x =>
                                                        {
                                                            //if (CurrentDirLeft == null)
                                                            //{
                                                            //    return;
                                                            //}
                                                            if (!left.goDirectory(currentFileLeft))
                                                            {
                                                                MessageBox.Show(Resources.Resources.ErrorMessageCannotOpen);
                                                            }
                                                            else
                                                            {
                                                                onPropertyChanged(nameof(CurrentDirLeft), nameof(CurrentPathLeft));
                                                            }
                                                        },
                                                            x => true
                                                        );
                }
                return goToDirectoryLeft;
            }
        }

        private ICommand goToDirectoryRight = null;
        public ICommand GoToDirectoryRight
        {
            get
            {
                if (goToDirectoryRight == null)
                {
                    goToDirectoryRight = new RelayCommand(
                                                            x =>
                                                            {
                                                                if (CurrentDirRight == null)
                                                                {
                                                                    return;
                                                                }
                                                                if (!right.goDirectory(currentFileRight))
                                                                {
                                                                    MessageBox.Show(Resources.Resources.ErrorMessageCannotOpen);
                                                                }
                                                                else
                                                                {
                                                                    onPropertyChanged(nameof(CurrentDirRight), nameof(CurrentPathRight));
                                                                }
                                                            },
                                                            x => true
                                                        );
                }
                return goToDirectoryRight;
            }
        }

        //copy
        private ICommand copy = null;
        public ICommand Copy
        {
            get
            {
                if (copy == null)
                {
                    copy = new RelayCommand(x => CopyFileOrDir(), x => true);
                }
                return copy;
            }
        }

        #endregion

        #region Methods

        private void CopyFileOrDir()
        {
            if (focusedSide == left)
            {
                FileOperations.Copy(currentFileLeft, left.CurrentPath, right.CurrentPath);
                right.getContent(right.CurrentPath);
                onPropertyChanged(nameof(CurrentDirRight));
            }
            if (focusedSide == right)
            {
                FileOperations.Copy(currentFileRight, right.CurrentPath, left.CurrentPath);
                left.getContent(left.CurrentPath);
                onPropertyChanged(nameof(CurrentDirLeft));
            }
        }


        #endregion
    }
}
