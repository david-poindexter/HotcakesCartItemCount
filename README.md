# Hotcakes Cart Item Count
This is a DNN theme / skin object for use with [Hotcakes Commerce](http://www.hotcakescommerce.com).  It utilizes the Hotcakes **Server-Side API** to obtain the current customer's cart line item count and display it.

## Project Dependicies
| DNN         | Hotcakes Commerce |
|:-----------:|:-----------------:|
| `7.4.1.280` | `01.08.07`        |

## Usage
#### Styling
Styling can be added to **HotcakesCartItemCount.ascx** utilizing CssClass or inline styling.

#### Manual Installation
We hope to add a build script to the project soon to auto-generate a Private Assembly package for easy installation within DNN.  Until then, only one folder needs to be manually created and two files copied over to the DNN instance file/folder structure.
<br />
<br />
##### Create folder
1. Within DNN instance, create a folder named **HotcakesCartItemCount** within **~/DesktopModules**.
<br />
<br />

##### Copy two files over
1. Copy **HotcakesCartItemCount.ascx** from this project to the new folder just created above within DNN.
<br />
<br />
2. Copy **HotcakesCartItemCount.dll** from this project (**/bin** folder) to **~/bin** within DNN.
<br /><br />

#### Registering within DNN theme/skin
+ Be sure to register the theme/skin object at the top of desired ASCX theme files:
```html
<%@ Register TagPrefix="hcc" TagName="CartItemCount" Src="~/DesktopModules/HotcakesCartItemCount/HotcakesCartItemCount.ascx" %>
```
<br />
+ Utilize the following code within the desired ASCX theme/skin files:
```html
<hcc:CartItemCount id="hccCartItemCount" runat="server" />
``` 
