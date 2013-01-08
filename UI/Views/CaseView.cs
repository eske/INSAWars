﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using INSAWars.Game;
using INSAWars.MVVM;
using System.ComponentModel;
using INSAWars.Units;

namespace UI.Views
{
    public class CaseView : ObservableObject
    {
        private string _type;
        private int _food;
        private int _iron;
        private List<UnitView> _units;
        private UnitView _selectedUnitView;
        private bool _selectedUnitCanMove;
        private bool _selectedUnitCanBuildCity;
        private bool _selectedUnitCanAttack;
        private Game _game;

        public CaseView(Game g, Case c)
        {
            _game = g;
            Units = c.Units.Select(u => new UnitView(u)).ToList();
            Type = c.ToString();
            Food = c.Food;
            Iron = c.Iron;
            SelectedUnitCanMove = false;
            SelectedUnitCanBuildCity = false;
            SelectedUnitCanAttack = false;
            SelectedUnitView = null;
        }

        public string Type
        {
            get { return _type; }
            set
            {
                SetProperty(ref _type, value);
            }
        }

        public int Food
        {
            get { return _food; }
            set
            {
                SetProperty(ref _food, value);
            }
        }

        public int Iron
        {
            get { return _iron; }
            set
            {
                SetProperty(ref _iron, value);
            }
        }

        public List<UnitView> Units
        {
            get { return _units; }
            set
            {
                SetProperty(ref _units, value);
            }
        }

        public UnitView SelectedUnitView
        {
            get { return _selectedUnitView; }
            set
            {
                SetProperty(ref _selectedUnitView, value);
                SelectedUnitCanMove = (value != null) && (value.Unit.Player == _game.CurrentPlayer) && value.Unit.CanMove();
                SelectedUnitCanBuildCity = (value != null) && (value.Unit.Player == _game.CurrentPlayer) && value.Unit is Teacher;
                SelectedUnitCanAttack = (value != null) && (value.Unit.Player == _game.CurrentPlayer) && value.Unit.CanAttack();
            }
        }

        public bool SelectedUnitCanMove
        {
            get { return _selectedUnitCanMove; }
            set
            {
                SetProperty(ref _selectedUnitCanMove, value);
            }
        }

        public bool SelectedUnitCanBuildCity
        {
            get { return _selectedUnitCanBuildCity; }
            set
            {
                SetProperty(ref _selectedUnitCanBuildCity, value);
            }
        }

        public bool SelectedUnitCanAttack
        {
            get { return _selectedUnitCanAttack; }
            set
            {
                SetProperty(ref _selectedUnitCanAttack, value);
            }
        }
    }
}