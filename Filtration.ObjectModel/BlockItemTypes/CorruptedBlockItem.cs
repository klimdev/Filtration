﻿using System.Windows.Media;
using Filtration.ObjectModel.BlockItemBaseTypes;

namespace Filtration.ObjectModel.BlockItemTypes
{
    public sealed class CorruptedBlockItem : BooleanBlockItem
    {
        public CorruptedBlockItem()
        {
        }

        public CorruptedBlockItem(bool booleanValue) : base(booleanValue)
        {
        }

        public override string PrefixText => "Corrupted";
        public override string DisplayHeading => "Corrupted";
        public override Color SummaryBackgroundColor => Colors.DarkRed;
        public override Color SummaryTextColor => Colors.White;
        public override int SortOrder => 5;

    }
}