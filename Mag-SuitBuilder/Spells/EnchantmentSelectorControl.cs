using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Drawing;
using System.Windows.Forms;

using Mag.Shared.Spells;

namespace Mag_SuitBuilder.Spells
{
	public partial class EnchantmentSelectorControl : UserControl, ICollection<Spell>, INotifyCollectionChanged
	{
		public EnchantmentSelectorControl()
		{
			InitializeComponent();

			dataGridView1.Rows.Add(9);

			dataGridView1[0, 0].Value = "Strength";			dataGridView1[0, 0].Tag = new[] { SpellTools.GetSpell(4325), SpellTools.GetSpell(2087), SpellTools.GetSpell(1332) };
			dataGridView1[0, 1].Value = "Endurance";		dataGridView1[0, 1].Tag = new[] { SpellTools.GetSpell(4299), SpellTools.GetSpell(2061), SpellTools.GetSpell(1354) };
			dataGridView1[0, 2].Value = "Coordination";		dataGridView1[0, 2].Tag = new[] { SpellTools.GetSpell(4297), SpellTools.GetSpell(2059), SpellTools.GetSpell(1378) };
			dataGridView1[0, 3].Value = "Quickness";		dataGridView1[0, 3].Tag = new[] { SpellTools.GetSpell(4319), SpellTools.GetSpell(2081), SpellTools.GetSpell(1402) };
			dataGridView1[0, 4].Value = "Focus";			dataGridView1[0, 4].Tag = new[] { SpellTools.GetSpell(4305), SpellTools.GetSpell(2067), SpellTools.GetSpell(1426) };
			dataGridView1[0, 5].Value = "Willpower";		dataGridView1[0, 5].Tag = new[] { SpellTools.GetSpell(4329), SpellTools.GetSpell(2091), SpellTools.GetSpell(1450) };
			dataGridView1[0, 6].Value = "Regeneration";		dataGridView1[0, 6].Tag = new[] { SpellTools.GetSpell(4496), SpellTools.GetSpell(2185), SpellTools.GetSpell(170) };
			dataGridView1[0, 7].Value = "Rejuvenation";		dataGridView1[0, 7].Tag = new[] { SpellTools.GetSpell(4498), SpellTools.GetSpell(2187), SpellTools.GetSpell(193) };
			dataGridView1[0, 8].Value = "Mana Renewal";		dataGridView1[0, 8].Tag = new[] { SpellTools.GetSpell(4494), SpellTools.GetSpell(2183), SpellTools.GetSpell(217) };
			//

			dataGridView1[1, 0].Value = "Blade Prot";		dataGridView1[1, 0].Tag = new[] { SpellTools.GetSpell(4462), SpellTools.GetSpell(2151), SpellTools.GetSpell(1114) }; // 3957 Epic Slashing Ward
			dataGridView1[1, 1].Value = "Piercing Prot";	dataGridView1[1, 1].Tag = new[] { SpellTools.GetSpell(4472), SpellTools.GetSpell(2161), SpellTools.GetSpell(1138) }; // 3956 Epic Piercing Ward
			dataGridView1[1, 2].Value = "Bludgeoning Prot"; dataGridView1[1, 2].Tag = new[] { SpellTools.GetSpell(4464), SpellTools.GetSpell(2153), SpellTools.GetSpell(1023) };
			dataGridView1[1, 3].Value = "Fire Prot";		dataGridView1[1, 3].Tag = new[] { SpellTools.GetSpell(4468), SpellTools.GetSpell(2157), SpellTools.GetSpell(1094) };
			dataGridView1[1, 4].Value = "Cold Prot";		dataGridView1[1, 4].Tag = new[] { SpellTools.GetSpell(4466), SpellTools.GetSpell(2155), SpellTools.GetSpell(1035) };
			dataGridView1[1, 5].Value = "Acid Prot";		dataGridView1[1, 5].Tag = new[] { SpellTools.GetSpell(4460), SpellTools.GetSpell(2149), SpellTools.GetSpell(520) };
			dataGridView1[1, 6].Value = "Lightning Prot";	dataGridView1[1, 6].Tag = new[] { SpellTools.GetSpell(4470), SpellTools.GetSpell(2159), SpellTools.GetSpell(1071) };
			dataGridView1[1, 7].Value = "Armor";			dataGridView1[1, 7].Tag = new[] { SpellTools.GetSpell(4291), SpellTools.GetSpell(2053), SpellTools.GetSpell(1312) };

			dataGridView1[2, 0].Value = "Life Magic";		dataGridView1[2, 0].Tag = new[] { SpellTools.GetSpell(4582), SpellTools.GetSpell(2267), SpellTools.GetSpell(610) };
			dataGridView1[2, 1].Value = "Creature Ench";	dataGridView1[2, 1].Tag = new[] { SpellTools.GetSpell(4530), SpellTools.GetSpell(2215), SpellTools.GetSpell(562) };
			dataGridView1[2, 2].Value = "Item Ench";		dataGridView1[2, 2].Tag = new[] { SpellTools.GetSpell(4564), SpellTools.GetSpell(2249), SpellTools.GetSpell(586) };
			dataGridView1[2, 3].Value = "War Magic";		dataGridView1[2, 3].Tag = new[] { SpellTools.GetSpell(4638), SpellTools.GetSpell(2323), SpellTools.GetSpell(634) };
			dataGridView1[2, 4].Value = "Void Magic";		dataGridView1[2, 4].Tag = new[] { SpellTools.GetSpell(5418), SpellTools.GetSpell(5417), SpellTools.GetSpell(5416) };
			dataGridView1[2, 5].Value = "Mana C";			dataGridView1[2, 5].Tag = new[] { SpellTools.GetSpell(4602), SpellTools.GetSpell(2287), SpellTools.GetSpell(658) };
			dataGridView1[2, 6].Value = "Arcane";			dataGridView1[2, 6].Tag = new[] { SpellTools.GetSpell(4510), SpellTools.GetSpell(2195), SpellTools.GetSpell(683) };

			dataGridView1[3, 0].Value = "Missile";			dataGridView1[3, 0].Tag = new[] { SpellTools.GetSpell(4522), SpellTools.GetSpell(2207), SpellTools.GetSpell(472) }; // 2219 2313, Missile Weapon Mastery 7	496 544,Missile Weapon Mastery 6
			dataGridView1[3, 1].Value = "Heavy";			dataGridView1[3, 1].Tag = new[] { SpellTools.GetSpell(4624), SpellTools.GetSpell(2309), SpellTools.GetSpell(423) };
			dataGridView1[3, 2].Value = "Light";			dataGridView1[3, 2].Tag = new[] { SpellTools.GetSpell(4631), SpellTools.GetSpell(2203), SpellTools.GetSpell(303) }; // 2275 2299 2305 2316,Light Weapon Mastery 7	351 375 399 448,Light Weapon Mastery 6
			dataGridView1[3, 3].Value = "Finesse";			dataGridView1[3, 3].Tag = new[] { SpellTools.GetSpell(4538), SpellTools.GetSpell(2223), SpellTools.GetSpell(327) };
			dataGridView1[3, 4].Value = "Healing";			dataGridView1[3, 4].Tag = new[] { SpellTools.GetSpell(4556), SpellTools.GetSpell(2241), SpellTools.GetSpell(879) };
			dataGridView1[3, 5].Value = "Shield";			dataGridView1[3, 5].Tag = new[] { SpellTools.GetSpell(5858), SpellTools.GetSpell(5857), SpellTools.GetSpell(5856) };

			dataGridView1[4, 0].Value = "Two Hand";			dataGridView1[4, 0].Tag = new[] { SpellTools.GetSpell(5032), SpellTools.GetSpell(5105), SpellTools.GetSpell(5104) };
			dataGridView1[4, 1].Value = "Dual Wield";		dataGridView1[4, 1].Tag = new[] { SpellTools.GetSpell(5810), SpellTools.GetSpell(5809), SpellTools.GetSpell(5808) };
			dataGridView1[4, 2].Value = "Dirty Fighting";	dataGridView1[4, 2].Tag = new[] { SpellTools.GetSpell(5786), SpellTools.GetSpell(5785), SpellTools.GetSpell(5784) };
			dataGridView1[4, 3].Value = "Recklessness";		dataGridView1[4, 3].Tag = new[] { SpellTools.GetSpell(5834), SpellTools.GetSpell(5833), SpellTools.GetSpell(5832) };
			dataGridView1[4, 4].Value = "Sneak Attack";		dataGridView1[4, 4].Tag = new[] { SpellTools.GetSpell(5882), SpellTools.GetSpell(5881), SpellTools.GetSpell(5880) };
			dataGridView1[4, 5].Value = "Deception";		dataGridView1[4, 5].Tag = new[] { SpellTools.GetSpell(4542), SpellTools.GetSpell(2227), SpellTools.GetSpell(855) };
			dataGridView1[4, 6].Value = "Summoning";		dataGridView1[4, 6].Tag = new[] { SpellTools.GetSpell(6123), SpellTools.GetSpell(6122), SpellTools.GetSpell(6121) };
			//
			//

			dataGridView1[5, 0].Value = "Invulnerability";	dataGridView1[5, 0].Tag = new[] { SpellTools.GetSpell(4560), SpellTools.GetSpell(2245), SpellTools.GetSpell(249) };
			dataGridView1[5, 1].Value = "Magic Resistance"; dataGridView1[5, 1].Tag = new[] { SpellTools.GetSpell(4596), SpellTools.GetSpell(2281), SpellTools.GetSpell(279) };
			dataGridView1[5, 2].Value = "Impregnability";	dataGridView1[5, 2].Tag = new[] { SpellTools.GetSpell(4558), SpellTools.GetSpell(2243), SpellTools.GetSpell(261) };
			dataGridView1[5, 5].Value = "Person";			dataGridView1[5, 5].Tag = new[] { SpellTools.GetSpell(4608), SpellTools.GetSpell(2293), SpellTools.GetSpell(829) };
			dataGridView1[5, 6].Value = "Monster";			dataGridView1[5, 6].Tag = new[] { SpellTools.GetSpell(4604), SpellTools.GetSpell(2289), SpellTools.GetSpell(803) };

			dataGridView1[6, 0].Value = "Item Tinker";		dataGridView1[6, 0].Tag = new[] { SpellTools.GetSpell(4566), SpellTools.GetSpell(2251), SpellTools.GetSpell(731) }; // 5068, Item Tinkering Expertise 8	 5067,Item Tinkering Expertise 7	 5066,Item Tinkering Expertise 6
			dataGridView1[6, 1].Value = "Armor Tinker";		dataGridView1[6, 1].Tag = new[] { SpellTools.GetSpell(4512), SpellTools.GetSpell(2197), SpellTools.GetSpell(707) };
			dataGridView1[6, 2].Value = "Weapon Tinker";	dataGridView1[6, 2].Tag = new[] { SpellTools.GetSpell(4640), SpellTools.GetSpell(2325), SpellTools.GetSpell(779) };
			dataGridView1[6, 3].Value = "Magic Item";		dataGridView1[6, 3].Tag = new[] { SpellTools.GetSpell(4592), SpellTools.GetSpell(2277), SpellTools.GetSpell(755) };
			dataGridView1[6, 4].Value = "Cooking";			dataGridView1[6, 4].Tag = new[] { SpellTools.GetSpell(4526), SpellTools.GetSpell(2211), SpellTools.GetSpell(1720) };
			dataGridView1[6, 5].Value = "Alchemy";			dataGridView1[6, 5].Tag = new[] { SpellTools.GetSpell(4506), SpellTools.GetSpell(2191), SpellTools.GetSpell(1768) };
			dataGridView1[6, 6].Value = "Fletching";		dataGridView1[6, 6].Tag = new[] { SpellTools.GetSpell(4552), SpellTools.GetSpell(2237), SpellTools.GetSpell(1744) };
			dataGridView1[6, 7].Value = "Lockpick";			dataGridView1[6, 7].Tag = new[] { SpellTools.GetSpell(4586), SpellTools.GetSpell(2271), SpellTools.GetSpell(927) };

			// Run through and check for errors
			/*
			foreach (DataGridViewRow row in dataGridView1.Rows)
			{
				foreach (DataGridViewCell cell in row.Cells)
				{
					if (cell.Tag == null)
						continue;

					Spell[] cellSpells = cell.Tag as Spell[];
					
					if (cellSpells != null)
					{
						for (int i = 1 ; i < cellSpells.Length ; i++)
						{
							if (!cellSpells[0].IsOfSameFamilyAndGroup(cellSpells[i]))
								throw new Exception("Spell group mismatch detected for cell: " + cell.Value + " " + cellSpells[0] + " - " + cellSpells[i]);
						}
					}
				}
			}
			*/
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);

			lblLoadDefaults.Visible = Enabled;
			defaultsComboBox.Visible = Enabled;
			cmdClear.Visible = Enabled;
		}

		readonly Collection<Spell> items = new Collection<Spell>();

		public event NotifyCollectionChangedEventHandler CollectionChanged;
		private bool suspendChangedEvent;

		public IEnumerator<Spell> GetEnumerator()
		{
			return items.GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(Spell item)
		{
			for (int i = items.Count - 1; i >= 0; i--)
			{
				if (items[i].IsSameOrSurpasses(item))
					return;

				if (item.Surpasses(items[i]))
					Remove(items[i]);
			}

			items.Add(item);

			if (!suspendChangedEvent && CollectionChanged != null)
				CollectionChanged(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, item));

			foreach (DataGridViewRow row in dataGridView1.Rows)
			{
				foreach (DataGridViewCell cell in row.Cells)
				{
					if (cell.Tag == null)
						continue;

					Spell[] spells = cell.Tag as Spell[];

					if (spells != null && spells[0].IsOfSameFamilyAndGroup(item))
					{
						Color newColor = Color.Empty;

						if (spells.Length > 0 && item.IsSameOrSurpasses(spells[0]))
							newColor = lblEights.BackColor;
						else if (spells.Length > 1 && item.IsSameOrSurpasses(spells[1]))
							newColor = lblSevens.BackColor;
						else if (spells.Length > 2 && item.IsSameOrSurpasses(spells[2]))
							newColor = lblSixes.BackColor;

						cell.Style.BackColor = newColor;
						cell.Style.SelectionBackColor = newColor;

						return;
					}
				}
			}
		}

		public void Clear()
		{
			items.Clear();

			if (!suspendChangedEvent && CollectionChanged != null)
				CollectionChanged(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));

			foreach (DataGridViewRow row in dataGridView1.Rows)
			{
				foreach (DataGridViewCell cell in row.Cells)
				{
					cell.Style.BackColor = Color.Empty;
					cell.Style.SelectionBackColor = Color.Empty;
				}
			}
		}

		public bool Contains(Spell item)
		{
			return items.Contains(item);
		}

		public void CopyTo(Spell[] array, int arrayIndex)
		{
			items.CopyTo(array, arrayIndex);
		}

		public bool Remove(Spell item)
		{
			bool result = items.Remove(item);

			if (result)
			{
				if (!suspendChangedEvent && CollectionChanged != null)
					CollectionChanged(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Remove, item));
			}

			foreach (DataGridViewRow row in dataGridView1.Rows)
			{
				foreach (DataGridViewCell cell in row.Cells)
				{
					if (cell.Tag == null)
						continue;

					Spell[] spells = cell.Tag as Spell[];

					if (spells != null && spells[0].IsOfSameFamilyAndGroup(item))
					{
						cell.Style.BackColor = Color.Empty;
						cell.Style.SelectionBackColor = Color.Empty;
						return result;
					}
				}
			}

			return result;
		}

		public int Count { get { return items.Count; } }
		public bool IsReadOnly { get { return false; } }

		public void LoadDefaults(string skill)
		{
			suspendChangedEvent = true;

			Clear();

			Add(SpellTools.GetSpell(6123)); // Summoning

			// Attributes
			switch (skill)
			{
				case "War":
				case "Void":
					Add(SpellTools.GetSpell(4299)); // Endurance
					Add(SpellTools.GetSpell(4297)); // Coordination
					Add(SpellTools.GetSpell(4319)); // Quickness
					Add(SpellTools.GetSpell(4305)); // Focus
					Add(SpellTools.GetSpell(4329)); // Willpower
					break;

				case "Generic":
				case "Missile":
				case "Heavy":
				case "Light":
				case "Finesse":
				case "Two Hand":
				case "Dual Wield":
					Add(SpellTools.GetSpell(4325)); // Strength
					Add(SpellTools.GetSpell(4299)); // Endurance
					Add(SpellTools.GetSpell(4297)); // Coordination
					Add(SpellTools.GetSpell(4319)); // Quickness
					Add(SpellTools.GetSpell(4305)); // Focus
					Add(SpellTools.GetSpell(4329)); // Willpower
					Add(SpellTools.GetSpell(4496)); // Regeneration
					Add(SpellTools.GetSpell(4498)); // Rejuvenation
					break;

				case "Tinker":
					Add(SpellTools.GetSpell(4325)); // Strength
					Add(SpellTools.GetSpell(4299)); // Endurance	
					Add(SpellTools.GetSpell(4297)); // Coordination
					Add(SpellTools.GetSpell(4305)); // Focus
					break;
			}

			// Wards
			switch (skill)
			{
				case "Generic":
				case "War":
				case "Void":
				case "Missile":
				case "Heavy":
				case "Light":
				case "Finesse":
				case "Two Hand":
				case "Dual Wield":
					Add(SpellTools.GetSpell(4462)); // Blade Prot
					Add(SpellTools.GetSpell(4472)); // Piercing Prot
					Add(SpellTools.GetSpell(4464)); // Bludgeoning Prot
					Add(SpellTools.GetSpell(4468)); // Fire Prot
					Add(SpellTools.GetSpell(4466)); // Cold Prot
					Add(SpellTools.GetSpell(4460)); // Acid Prot
					Add(SpellTools.GetSpell(4470)); // Lightning Prot
					Add(SpellTools.GetSpell(4291)); // Armor
					break;

				case "Tinker":
					break;
			}

			// Defenses
			switch (skill)
			{
				case "Generic":
				case "War":
				case "Void":
				case "Missile":
				case "Heavy":
				case "Light":
				case "Finesse":
				case "Two Hand":
				case "Dual Wield":
					Add(SpellTools.GetSpell(4560)); // Melee Defense
					Add(SpellTools.GetSpell(4596)); // Magic Defense
					Add(SpellTools.GetSpell(4558)); // Missile Defense 
					Add(SpellTools.GetSpell(4564)); // Item Ench
					break;

				case "Tinker":
					break;
			}

			// Skills
			switch (skill)
			{
				case "War":
					Add(SpellTools.GetSpell(4638)); // War Magic
					Add(SpellTools.GetSpell(4602)); // Mana C
					Add(SpellTools.GetSpell(4510)); // Arcane
					break;
				case "Void":
					Add(SpellTools.GetSpell(5418)); // Void Magic
					Add(SpellTools.GetSpell(4602)); // Mana C
					Add(SpellTools.GetSpell(4510)); // Arcane
					break;
				case "Missile":
					Add(SpellTools.GetSpell(4522)); // Missile
					Add(SpellTools.GetSpell(4556)); // Healing
					Add(SpellTools.GetSpell(4552)); // Fletching
					break;
				case "Heavy":
					Add(SpellTools.GetSpell(4624)); // Heavy
					Add(SpellTools.GetSpell(4556)); // Healing
					break;
				case "Light":
					Add(SpellTools.GetSpell(4631)); // Light
					Add(SpellTools.GetSpell(4556)); // Healing
					break;
				case "Finesse":
					Add(SpellTools.GetSpell(4538));	// Finesse		
					Add(SpellTools.GetSpell(4556)); // Healing
					break;
				case "Two Hand":
					Add(SpellTools.GetSpell(5032)); // Two Hand
					Add(SpellTools.GetSpell(4556)); // Healing
					break;
				case "Dual Wield":
					Add(SpellTools.GetSpell(5810)); // Dual Wield
					Add(SpellTools.GetSpell(4556)); // Healing
					break;

				case "Tinker":
					Add(SpellTools.GetSpell(4566)); // Item Tinker
					Add(SpellTools.GetSpell(4512)); // Armor Tinker
					Add(SpellTools.GetSpell(4640)); // Weapon Tinker
					Add(SpellTools.GetSpell(4592)); // Magic Item
					Add(SpellTools.GetSpell(4526)); // Cooking
					Add(SpellTools.GetSpell(4506)); // Alchemy
					break;
			}

			if (CollectionChanged != null)
				CollectionChanged(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));

			suspendChangedEvent = false;
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			DataGridViewCell cell = dataGridView1[e.ColumnIndex, e.RowIndex];

			if (cell.Value == null || cell.Tag == null)
				return;

			int index = -1;

			if (cell.Style.BackColor == lblEights.BackColor)
				index = 0;
			else if (cell.Style.BackColor == lblSevens.BackColor)
				index = 1;
			else if (cell.Style.BackColor == lblSixes.BackColor)
				index = 2;

			Spell[] spells = cell.Tag as Spell[];

			if (spells == null)
				return;

			if (index != -1)
				Remove(spells[index]);

			if (index >= spells.Length - 1)
				return;

			index++;

			Add(spells[index]);
		}

		private void cmdClear_Click(object sender, EventArgs e)
		{
			defaultsComboBox.Text = "";

			Clear();
		}

		private void defaultsComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			LoadDefaults(defaultsComboBox.Text);
		}
	}
}
