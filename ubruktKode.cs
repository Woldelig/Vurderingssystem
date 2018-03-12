
/*
    Under så er kodesnutt for å lage 5 radioknapperved hjelp av en metode. De ville ha blitt lagt inn i en div som er visst under
    Dette ble erstatt med rateIt, men er fullt brukbar kode vi kan legge i rapporten.
 */

<div class="col-md-4"><table id="spm1RadioknappDiv" runat="server"> </table></div>

HtmlTable[] spmKnappDiv = new HtmlTable[10] { spm1RadioknappDiv, spm2RadioknappDiv, spm3RadioknappDiv, spm4RadioknappDiv, spm5RadioknappDiv, spm6RadioknappDiv, spm7RadioknappDiv, spm8RadioknappDiv, spm9RadioknappDiv, spm10RadioknappDiv };
            foreach (var div in spmKnappDiv)
            {
                LagRadioKnapper(div);
            }


void LagRadioKnapper(HtmlTable radioKnappDiv)
        {

            HtmlTableRow row = new HtmlTableRow();
            for (int i = 0; i < 5; i++)
            {
                HtmlTableCell cell = new HtmlTableCell();
                RadioButton radioButton = new RadioButton();
                cell.Controls.Add(radioButton);
                row.Cells.Add(cell);
            }
            radioKnappDiv.Rows.Add(row);
        }