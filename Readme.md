# Online Parser

## Overview
This application currently parsers certain pages provided from NowInStock.net and coverts the content into a JSON output to be later parsed by a front-end client

### Sample input

> https://www.nowinstock.net/modules/history/us/1423.html

```HTML
<div><a href="#" onClick="$('#spinner3').show();nisgen.ajpage('/modules/history/us/1423.html','DisplayHistory');$('#spinner3').fadeOut(2000);return false;"><img src="https://s3.amazonaws.com/NowInStock.net/images/main/icon_refresh.jpg" align="absmiddle" border="0"></a> - Updates apprx. every 5 minutes. <img id="spinner3" style="display:none;" src="/images/icons/refresh.gif" align="absmiddle"></div><div id="data"><table width="610">
				<tr bgcolor="#CCCCCC">
					<th width="150">Date/Time</th>
					<th>Status</th>
					</tr><tr onMouseOver="this.bgColor='#99FF99'" onMouseOut="this.bgColor=''"><td>Apr 28 - 9:33 PM EST</td><td>Amazon : Seventh Generation 2-ply 6/2 Out of Stock</td>
						</tr><tr onMouseOver="this.bgColor='#99FF99'" onMouseOut="this.bgColor=''"><td>Apr 28 - 9:17 PM EST</td><td>Amazon : Seventh Generation 2-ply 6/2 Preorder for $22.99</td>
						</tr><tr onMouseOver="this.bgColor='#99FF99'" onMouseOut="this.bgColor=''"><td>Apr 28 - 6:50 PM EST</td><td>Amazon : Seventh Generation 2-ply 6/2 Out of Stock</td>
						</tr><tr onMouseOver="this.bgColor='#99FF99'" onMouseOut="this.bgColor=''"><td>Apr 28 - 6:18 PM EST</td><td>Amazon : Seventh Generation 2-ply 6/2 In Stock for $22.99</td>
						</tr><tr onMouseOver="this.bgColor='#99FF99'" onMouseOut="this.bgColor=''"><td>Apr 28 - 4:58 PM EST</td><td>Amazon : Seventh Generation 2-ply 6/2 Out of Stock</td>
						</tr><tr onMouseOver="this.bgColor='#99FF99'" onMouseOut="this.bgColor=''"><td>Apr 28 - 4:41 PM EST</td><td>Amazon : Seventh Generation 2-ply 6/2 Preorder for $22.99</td>
						</tr><tr onMouseOver="this.bgColor='#99FF99'" onMouseOut="this.bgColor=''"><td>Apr 28 - 2:52 PM EST</td><td>Amazon : Scott Shop Towels Original (75130) 55/30 Out of Stock</td>
						</tr><tr onMouseOver="this.bgColor='#99FF99'" onMouseOut="this.bgColor=''"><td>Apr 28 - 1:33 PM EST</td><td>Amazon : Kleenex Multifold Tri-Fold White 150/16 Out of Stock</td>
						</tr><tr onMouseOver="this.bgColor='#99FF99'" onMouseOut="this.bgColor=''"><td>Apr 28 - 1:17 PM EST</td><td>Amazon : Kleenex Multifold Tri-Fold White 150/16 Preorder for $31.19</td>
						</tr><tr onMouseOver="this.bgColor='#99FF99'" onMouseOut="this.bgColor=''"><td>Apr 28 - 1:01 PM EST</td><td>Amazon : Kleenex Multifold Tri-Fold White 150/16 Out of Stock</td>
						</tr></table></div>
```
### Sample output

```JSON
[
    {
        "Vendor": "Value",
        "Description": "Value",
        "Status": "Value",
        "LastStock": "2020-04-14"
    },
    {
        "Vendor": "Value",
        "Description": "Value",
        "Status": "Value",
        "LastStock": "2020-04-14"
    }
]
```