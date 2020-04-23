<%@ Page Title="" Language="C#" MasterPageFile="~/TimeLine.Master" AutoEventWireup="true" CodeBehind="TimelIne_EditBasicInfo.aspx.cs" Inherits="SocialNetProject.TimelIne_EditBasicInfo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="tab-pane active" id="register">
        <h3>Edit Your Basic Info !</h3>
        <p class="text-muted"></p>

        <!--Register Form-->

        <div class="row">
            <div class="form-group col-xs-6">
                <label for="firstname" class="sr-only">First Name</label>
                <asp:textbox id="TextBox1" cssclass="form-control input-group-lg" placeholder="First name" runat="server"></asp:textbox>
            </div>
            <div class="form-group col-xs-6">
                <label for="lastname" class="sr-only">Last Name</label>
                <asp:textbox id="TextBox2" cssclass="form-control input-group-lg" placeholder="Last name" runat="server"></asp:textbox>
            </div>
        </div>
        <div class="row">
            <p class="birth"><strong>Date of Birth</strong></p>
            <div class="form-group col-sm-3 col-xs-6">
                <label for="month" class="sr-only"></label>

                <asp:dropdownlist class="form-control" id="DropDownList1" runat="server">

                                                <asp:ListItem>01</asp:ListItem>
                                                <asp:ListItem>02</asp:ListItem>
                                                <asp:ListItem>03</asp:ListItem>
                                                <asp:ListItem>04</asp:ListItem>
                                                <asp:ListItem>05</asp:ListItem>
                                                <asp:ListItem>06</asp:ListItem>
                                                <asp:ListItem>07</asp:ListItem>
                                                <asp:ListItem>08</asp:ListItem>
                                                <asp:ListItem>09</asp:ListItem>
                                                <asp:ListItem>10</asp:ListItem>
                                                <asp:ListItem>11</asp:ListItem>
                                                <asp:ListItem>12</asp:ListItem>
                                                <asp:ListItem>13</asp:ListItem>
                                                <asp:ListItem>14</asp:ListItem>
                                                <asp:ListItem>15</asp:ListItem>
                                                <asp:ListItem>16</asp:ListItem>
                                                <asp:ListItem>17</asp:ListItem>
                                                <asp:ListItem>18</asp:ListItem>
                                                <asp:ListItem>19</asp:ListItem>
                                                <asp:ListItem>20</asp:ListItem>
                                                <asp:ListItem>21</asp:ListItem>
                                                <asp:ListItem>22</asp:ListItem>
                                                <asp:ListItem>23</asp:ListItem>
                                                <asp:ListItem>24</asp:ListItem>
                                                <asp:ListItem>25</asp:ListItem>
                                                <asp:ListItem>26</asp:ListItem>
                                                <asp:ListItem>27</asp:ListItem>
                                                <asp:ListItem>28</asp:ListItem>
                                                <asp:ListItem>29</asp:ListItem>
                                                <asp:ListItem>30</asp:ListItem>
                                                <asp:ListItem>31</asp:ListItem>

                                            </asp:dropdownlist>


            </div>
            <div class="form-group col-sm-3 col-xs-6">
                <label for="month" class="sr-only"></label>

                <asp:dropdownlist class="form-control" id="DropDownList2" runat="server">
                                                <asp:ListItem Value="01">Jan</asp:ListItem>
                                                <asp:ListItem Value="02">Feb</asp:ListItem>
                                                <asp:ListItem Value="03">Mar</asp:ListItem>
                                                <asp:ListItem Value="04">Apr</asp:ListItem>
                                                <asp:ListItem Value="05">May</asp:ListItem>
                                                <asp:ListItem Value="06">Jun</asp:ListItem>
                                                <asp:ListItem Value="07">Jul</asp:ListItem>
                                                <asp:ListItem Value="08">Aug</asp:ListItem>
                                                <asp:ListItem Value="09">Sep</asp:ListItem>
                                                <asp:ListItem Value="10">Oct</asp:ListItem>
                                                <asp:ListItem Value="11">Nov</asp:ListItem>
                                                <asp:ListItem Value="12">Dec</asp:ListItem>
                                            </asp:dropdownlist>


            </div>
            <div class="form-group col-sm-6 col-xs-12">
                <label for="year" class="sr-only"></label>

                <asp:dropdownlist class="form-control" id="DropDownList3" runat="server">

                                                <asp:ListItem>2000</asp:ListItem>
                                                <asp:ListItem>2001</asp:ListItem>
                                                <asp:ListItem>2002</asp:ListItem>
                                                <asp:ListItem>2004</asp:ListItem>
                                                <asp:ListItem>2005</asp:ListItem>
                                                <asp:ListItem>2006</asp:ListItem>
                                                <asp:ListItem>2007</asp:ListItem>
                                                <asp:ListItem>2008</asp:ListItem>
                                                <asp:ListItem>2009</asp:ListItem>
                                                <asp:ListItem>2010</asp:ListItem>
                                                <asp:ListItem>2011</asp:ListItem>
                                                <asp:ListItem>2012</asp:ListItem>

                                            </asp:dropdownlist>
            </div>
        </div>
        <div class="form-group gender">
            <label class="radio-inline">

                <asp:radiobutton id="RadioButton1" groupname="Gender" runat="server" text="Male" checked="True" />
            </label>
            <label class="radio-inline">

                <asp:radiobutton id="RadioButton2" groupname="Gender" runat="server" text="Female" />
            </label>
        </div>
        <div class="row">
            <div class="form-group col-xs-6">
                <label for="city" class="sr-only">City</label>

                <asp:textbox id="TextBox5" cssclass="form-control input-group-lg" placeholder="City" runat="server"></asp:textbox>

            </div>
            <div class="form-group col-xs-6">
                <label for="country" class="sr-only"></label>
                <asp:dropdownlist class="form-control" id="DropDownList4" runat="server">

                                                <asp:ListItem Value="AFG">Afghanistan</asp:ListItem>
                                                <asp:ListItem Value="ALA">�land Islands</asp:ListItem>
                                                <asp:ListItem Value="ALB">Albania</asp:ListItem>
                                                <asp:ListItem Value="DZA">Algeria</asp:ListItem>
                                                <asp:ListItem Value="ASM">American Samoa</asp:ListItem>
                                                <asp:ListItem Value="AND">Andorra</asp:ListItem>
                                                <asp:ListItem Value="AGO">Angola</asp:ListItem>
                                                <asp:ListItem Value="AIA">Anguilla</asp:ListItem>
                                                <asp:ListItem Value="ATA">Antarctica</asp:ListItem>
                                                <asp:ListItem Value="ATG">Antigua and Barbuda</asp:ListItem>
                                                <asp:ListItem Value="ARG">Argentina</asp:ListItem>
                                                <asp:ListItem Value="ARM">Armenia</asp:ListItem>
                                                <asp:ListItem Value="ABW">Aruba</asp:ListItem>
                                                <asp:ListItem Value="AUS">Australia</asp:ListItem>
                                                <asp:ListItem Value="AUT">Austria</asp:ListItem>
                                                <asp:ListItem Value="AZE">Azerbaijan</asp:ListItem>
                                                <asp:ListItem Value="BHS">Bahamas</asp:ListItem>
                                                <asp:ListItem Value="BHR">Bahrain</asp:ListItem>
                                                <asp:ListItem Value="BGD">Bangladesh</asp:ListItem>
                                                <asp:ListItem Value="BRB">Barbados</asp:ListItem>
                                                <asp:ListItem Value="BLR">Belarus</asp:ListItem>
                                                <asp:ListItem Value="BEL">Belgium</asp:ListItem>
                                                <asp:ListItem Value="BLZ">Belize</asp:ListItem>
                                                <asp:ListItem Value="BEN">Benin</asp:ListItem>
                                                <asp:ListItem Value="BMU">Bermuda</asp:ListItem>
                                                <asp:ListItem Value="BTN">Bhutan</asp:ListItem>
                                                <asp:ListItem Value="BOL">Bolivia, Plurinational State of</asp:ListItem>
                                                <asp:ListItem Value="BES">Bonaire, Sint Eustatius and Saba</asp:ListItem>
                                                <asp:ListItem Value="BIH">Bosnia and Herzegovina</asp:ListItem>
                                                <asp:ListItem Value="BWA">Botswana</asp:ListItem>
                                                <asp:ListItem Value="BVT">Bouvet Island</asp:ListItem>
                                                <asp:ListItem Value="BRA">Brazil</asp:ListItem>
                                                <asp:ListItem Value="IOT">British Indian Ocean Territory</asp:ListItem>
                                                <asp:ListItem Value="BRN">Brunei Darussalam</asp:ListItem>
                                                <asp:ListItem Value="BGR">Bulgaria</asp:ListItem>
                                                <asp:ListItem Value="BFA">Burkina Faso</asp:ListItem>
                                                <asp:ListItem Value="BDI">Burundi</asp:ListItem>
                                                <asp:ListItem Value="KHM">Cambodia</asp:ListItem>
                                                <asp:ListItem Value="CMR">Cameroon</asp:ListItem>
                                                <asp:ListItem Value="CAN">Canada</asp:ListItem>
                                                <asp:ListItem Value="CPV">Cape Verde</asp:ListItem>
                                                <asp:ListItem Value="CYM">Cayman Islands</asp:ListItem>
                                                <asp:ListItem Value="CAF">Central African Republic</asp:ListItem>
                                                <asp:ListItem Value="TCD">Chad</asp:ListItem>
                                                <asp:ListItem Value="CHL">Chile</asp:ListItem>
                                                <asp:ListItem Value="CHN">China</asp:ListItem>
                                                <asp:ListItem Value="CXR">Christmas Island</asp:ListItem>
                                                <asp:ListItem Value="CCK">Cocos (Keeling) Islands</asp:ListItem>
                                                <asp:ListItem Value="COL">Colombia</asp:ListItem>
                                                <asp:ListItem Value="COM">Comoros</asp:ListItem>
                                                <asp:ListItem Value="COG">Congo</asp:ListItem>
                                                <asp:ListItem Value="COD">Congo, the Democratic Republic of the</asp:ListItem>
                                                <asp:ListItem Value="COK">Cook Islands</asp:ListItem>
                                                <asp:ListItem Value="CRI">Costa Rica</asp:ListItem>
                                                <asp:ListItem Value="CIV">C�te d'Ivoire</asp:ListItem>
                                                <asp:ListItem Value="HRV">Croatia</asp:ListItem>
                                                <asp:ListItem Value="CUB">Cuba</asp:ListItem>
                                                <asp:ListItem Value="CUW">Cura�ao</asp:ListItem>
                                                <asp:ListItem Value="CYP">Cyprus</asp:ListItem>
                                                <asp:ListItem Value="CZE">Czech Republic</asp:ListItem>
                                                <asp:ListItem Value="DNK">Denmark</asp:ListItem>
                                                <asp:ListItem Value="DJI">Djibouti</asp:ListItem>
                                                <asp:ListItem Value="DMA">Dominica</asp:ListItem>
                                                <asp:ListItem Value="DOM">Dominican Republic</asp:ListItem>
                                                <asp:ListItem Value="ECU">Ecuador</asp:ListItem>
                                                <asp:ListItem Value="EGY">Egypt</asp:ListItem>
                                                <asp:ListItem Value="SLV">El Salvador</asp:ListItem>
                                                <asp:ListItem Value="GNQ">Equatorial Guinea</asp:ListItem>
                                                <asp:ListItem Value="ERI">Eritrea</asp:ListItem>
                                                <asp:ListItem Value="EST">Estonia</asp:ListItem>
                                                <asp:ListItem Value="ETH">Ethiopia</asp:ListItem>
                                                <asp:ListItem Value="FLK">Falkland Islands (Malvinas)</asp:ListItem>
                                                <asp:ListItem Value="FRO">Faroe Islands</asp:ListItem>
                                                <asp:ListItem Value="FJI">Fiji</asp:ListItem>
                                                <asp:ListItem Value="FIN">Finland</asp:ListItem>
                                                <asp:ListItem Value="FRA">France</asp:ListItem>
                                                <asp:ListItem Value="GUF">French Guiana</asp:ListItem>
                                                <asp:ListItem Value="PYF">French Polynesia</asp:ListItem>
                                                <asp:ListItem Value="ATF">French Southern Territories</asp:ListItem>
                                                <asp:ListItem Value="GAB">Gabon</asp:ListItem>
                                                <asp:ListItem Value="GMB">Gambia</asp:ListItem>
                                                <asp:ListItem Value="GEO">Georgia</asp:ListItem>
                                                <asp:ListItem Value="DEU">Germany</asp:ListItem>
                                                <asp:ListItem Value="GHA">Ghana</asp:ListItem>
                                                <asp:ListItem Value="GIB">Gibraltar</asp:ListItem>
                                                <asp:ListItem Value="GRC">Greece</asp:ListItem>
                                                <asp:ListItem Value="GRL">Greenland</asp:ListItem>
                                                <asp:ListItem Value="GRD">Grenada</asp:ListItem>
                                                <asp:ListItem Value="GLP">Guadeloupe</asp:ListItem>
                                                <asp:ListItem Value="GUM">Guam</asp:ListItem>
                                                <asp:ListItem Value="GTM">Guatemala</asp:ListItem>
                                                <asp:ListItem Value="GGY">Guernsey</asp:ListItem>
                                                <asp:ListItem Value="GIN">Guinea</asp:ListItem>
                                                <asp:ListItem Value="GNB">Guinea-Bissau</asp:ListItem>
                                                <asp:ListItem Value="GUY">Guyana</asp:ListItem>
                                                <asp:ListItem Value="HTI">Haiti</asp:ListItem>
                                                <asp:ListItem Value="HMD">Heard Island and McDonald Islands</asp:ListItem>
                                                <asp:ListItem Value="VAT">Holy See (Vatican City State)</asp:ListItem>
                                                <asp:ListItem Value="HND">Honduras</asp:ListItem>
                                                <asp:ListItem Value="HKG">Hong Kong</asp:ListItem>
                                                <asp:ListItem Value="HUN">Hungary</asp:ListItem>
                                                <asp:ListItem Value="ISL">Iceland</asp:ListItem>
                                                <asp:ListItem Value="IND">India</asp:ListItem>
                                                <asp:ListItem Value="IDN">Indonesia</asp:ListItem>
                                                <asp:ListItem Value="IRN">Iran, Islamic Republic of</asp:ListItem>
                                                <asp:ListItem Value="IRQ">Iraq</asp:ListItem>
                                                <asp:ListItem Value="IRL">Ireland</asp:ListItem>
                                                <asp:ListItem Value="IMN">Isle of Man</asp:ListItem>
                                                <asp:ListItem Value="ISR">Israel</asp:ListItem>
                                                <asp:ListItem Value="ITA">Italy</asp:ListItem>
                                                <asp:ListItem Value="JAM">Jamaica</asp:ListItem>
                                                <asp:ListItem Value="JPN">Japan</asp:ListItem>
                                                <asp:ListItem Value="JEY">Jersey</asp:ListItem>
                                                <asp:ListItem Value="JOR">Jordan</asp:ListItem>
                                                <asp:ListItem Value="KAZ">Kazakhstan</asp:ListItem>
                                                <asp:ListItem Value="KEN">Kenya</asp:ListItem>
                                                <asp:ListItem Value="KIR">Kiribati</asp:ListItem>
                                                <asp:ListItem Value="PRK">Korea, Democratic People's Republic of</asp:ListItem>
                                                <asp:ListItem Value="KOR">Korea, Republic of</asp:ListItem>
                                                <asp:ListItem Value="KWT">Kuwait</asp:ListItem>
                                                <asp:ListItem Value="KGZ">Kyrgyzstan</asp:ListItem>
                                                <asp:ListItem Value="LAO">Lao People's Democratic Republic</asp:ListItem>
                                                <asp:ListItem Value="LVA">Latvia</asp:ListItem>
                                                <asp:ListItem Value="LBN">Lebanon</asp:ListItem>
                                                <asp:ListItem Value="LSO">Lesotho</asp:ListItem>
                                                <asp:ListItem Value="LBR">Liberia</asp:ListItem>
                                                <asp:ListItem Value="LBY">Libya</asp:ListItem>
                                                <asp:ListItem Value="LIE">Liechtenstein</asp:ListItem>
                                                <asp:ListItem Value="LTU">Lithuania</asp:ListItem>
                                                <asp:ListItem Value="LUX">Luxembourg</asp:ListItem>
                                                <asp:ListItem Value="MAC">Macao</asp:ListItem>
                                                <asp:ListItem Value="MKD">Macedonia, the former Yugoslav Republic of</asp:ListItem>
                                                <asp:ListItem Value="MDG">Madagascar</asp:ListItem>
                                                <asp:ListItem Value="MWI">Malawi</asp:ListItem>
                                                <asp:ListItem Value="MYS">Malaysia</asp:ListItem>
                                                <asp:ListItem Value="MDV">Maldives</asp:ListItem>
                                                <asp:ListItem Value="MLI">Mali</asp:ListItem>
                                                <asp:ListItem Value="MLT">Malta</asp:ListItem>
                                                <asp:ListItem Value="MHL">Marshall Islands</asp:ListItem>
                                                <asp:ListItem Value="MTQ">Martinique</asp:ListItem>
                                                <asp:ListItem Value="MRT">Mauritania</asp:ListItem>
                                                <asp:ListItem Value="MUS">Mauritius</asp:ListItem>
                                                <asp:ListItem Value="MYT">Mayotte</asp:ListItem>
                                                <asp:ListItem Value="MEX">Mexico</asp:ListItem>
                                                <asp:ListItem Value="FSM">Micronesia, Federated States of</asp:ListItem>
                                                <asp:ListItem Value="MDA">Moldova, Republic of</asp:ListItem>
                                                <asp:ListItem Value="MCO">Monaco</asp:ListItem>
                                                <asp:ListItem Value="MNG">Mongolia</asp:ListItem>
                                                <asp:ListItem Value="MNE">Montenegro</asp:ListItem>
                                                <asp:ListItem Value="MSR">Montserrat</asp:ListItem>
                                                <asp:ListItem Value="MAR">Morocco</asp:ListItem>
                                                <asp:ListItem Value="MOZ">Mozambique</asp:ListItem>
                                                <asp:ListItem Value="MMR">Myanmar</asp:ListItem>
                                                <asp:ListItem Value="NAM">Namibia</asp:ListItem>
                                                <asp:ListItem Value="NRU">Nauru</asp:ListItem>
                                                <asp:ListItem Value="NPL">Nepal</asp:ListItem>
                                                <asp:ListItem Value="NLD">Netherlands</asp:ListItem>
                                                <asp:ListItem Value="NCL">New Caledonia</asp:ListItem>
                                                <asp:ListItem Value="NZL">New Zealand</asp:ListItem>
                                                <asp:ListItem Value="NIC">Nicaragua</asp:ListItem>
                                                <asp:ListItem Value="NER">Niger</asp:ListItem>
                                                <asp:ListItem Value="NGA">Nigeria</asp:ListItem>
                                                <asp:ListItem Value="NIU">Niue</asp:ListItem>
                                                <asp:ListItem Value="NFK">Norfolk Island</asp:ListItem>
                                                <asp:ListItem Value="MNP">Northern Mariana Islands</asp:ListItem>
                                                <asp:ListItem Value="NOR">Norway</asp:ListItem>
                                                <asp:ListItem Value="OMN">Oman</asp:ListItem>
                                                <asp:ListItem Value="PAK">Pakistan</asp:ListItem>
                                                <asp:ListItem Value="PLW">Palau</asp:ListItem>
                                                <asp:ListItem Value="PSE">Palestinian Territory, Occupied</asp:ListItem>
                                                <asp:ListItem Value="PAN">Panama</asp:ListItem>
                                                <asp:ListItem Value="PNG">Papua New Guinea</asp:ListItem>
                                                <asp:ListItem Value="PRY">Paraguay</asp:ListItem>
                                                <asp:ListItem Value="PER">Peru</asp:ListItem>
                                                <asp:ListItem Value="PHL">Philippines</asp:ListItem>
                                                <asp:ListItem Value="PCN">Pitcairn</asp:ListItem>
                                                <asp:ListItem Value="POL">Poland</asp:ListItem>
                                                <asp:ListItem Value="PRT">Portugal</asp:ListItem>
                                                <asp:ListItem Value="PRI">Puerto Rico</asp:ListItem>
                                                <asp:ListItem Value="QAT">Qatar</asp:ListItem>
                                                <asp:ListItem Value="REU">R�union</asp:ListItem>
                                                <asp:ListItem Value="ROU">Romania</asp:ListItem>
                                                <asp:ListItem Value="RUS">Russian Federation</asp:ListItem>
                                                <asp:ListItem Value="RWA">Rwanda</asp:ListItem>
                                                <asp:ListItem Value="BLM">Saint Barth�lemy</asp:ListItem>
                                                <asp:ListItem Value="SHN">Saint Helena, Ascension and Tristan da Cunha</asp:ListItem>
                                                <asp:ListItem Value="KNA">Saint Kitts and Nevis</asp:ListItem>
                                                <asp:ListItem Value="LCA">Saint Lucia</asp:ListItem>
                                                <asp:ListItem Value="MAF">Saint Martin (French part)</asp:ListItem>
                                                <asp:ListItem Value="SPM">Saint Pierre and Miquelon</asp:ListItem>
                                                <asp:ListItem Value="VCT">Saint Vincent and the Grenadines</asp:ListItem>
                                                <asp:ListItem Value="WSM">Samoa</asp:ListItem>
                                                <asp:ListItem Value="SMR">San Marino</asp:ListItem>
                                                <asp:ListItem Value="STP">Sao Tome and Principe</asp:ListItem>
                                                <asp:ListItem Value="SAU">Saudi Arabia</asp:ListItem>
                                                <asp:ListItem Value="SEN">Senegal</asp:ListItem>
                                                <asp:ListItem Value="SRB">Serbia</asp:ListItem>
                                                <asp:ListItem Value="SYC">Seychelles</asp:ListItem>
                                                <asp:ListItem Value="SLE">Sierra Leone</asp:ListItem>
                                                <asp:ListItem Value="SGP">Singapore</asp:ListItem>
                                                <asp:ListItem Value="SXM">Sint Maarten (Dutch part)</asp:ListItem>
                                                <asp:ListItem Value="SVK">Slovakia</asp:ListItem>
                                                <asp:ListItem Value="SVN">Slovenia</asp:ListItem>
                                                <asp:ListItem Value="SLB">Solomon Islands</asp:ListItem>
                                                <asp:ListItem Value="SOM">Somalia</asp:ListItem>
                                                <asp:ListItem Value="ZAF">South Africa</asp:ListItem>
                                                <asp:ListItem Value="SGS">South Georgia and the South Sandwich Islands</asp:ListItem>
                                                <asp:ListItem Value="SSD">South Sudan</asp:ListItem>
                                                <asp:ListItem Value="ESP">Spain</asp:ListItem>
                                                <asp:ListItem Value="LKA">Sri Lanka</asp:ListItem>
                                                <asp:ListItem Value="SDN">Sudan</asp:ListItem>
                                                <asp:ListItem Value="SUR">Suriname</asp:ListItem>
                                                <asp:ListItem Value="SJM">Svalbard and Jan Mayen</asp:ListItem>
                                                <asp:ListItem Value="SWZ">Swaziland</asp:ListItem>
                                                <asp:ListItem Value="SWE">Sweden</asp:ListItem>
                                                <asp:ListItem Value="CHE">Switzerland</asp:ListItem>
                                                <asp:ListItem Value="SYR">Syrian Arab Republic</asp:ListItem>
                                                <asp:ListItem Value="TWN">Taiwan, Province of China</asp:ListItem>
                                                <asp:ListItem Value="TJK">Tajikistan</asp:ListItem>
                                                <asp:ListItem Value="TZA">Tanzania, United Republic of</asp:ListItem>
                                                <asp:ListItem Value="THA">Thailand</asp:ListItem>
                                                <asp:ListItem Value="TLS">Timor-Leste</asp:ListItem>
                                                <asp:ListItem Value="TGO">Togo</asp:ListItem>
                                                <asp:ListItem Value="TKL">Tokelau</asp:ListItem>
                                                <asp:ListItem Value="TON">Tonga</asp:ListItem>
                                                <asp:ListItem Value="TTO">Trinidad and Tobago</asp:ListItem>
                                                <asp:ListItem Value="TUN">Tunisia</asp:ListItem>
                                                <asp:ListItem Value="TUR">Turkey</asp:ListItem>
                                                <asp:ListItem Value="TKM">Turkmenistan</asp:ListItem>
                                                <asp:ListItem Value="TCA">Turks and Caicos Islands</asp:ListItem>
                                                <asp:ListItem Value="TUV">Tuvalu</asp:ListItem>
                                                <asp:ListItem Value="UGA">Uganda</asp:ListItem>
                                                <asp:ListItem Value="UKR">Ukraine</asp:ListItem>
                                                <asp:ListItem Value="ARE">United Arab Emirates</asp:ListItem>
                                                <asp:ListItem Value="GBR">United Kingdom</asp:ListItem>
                                                <asp:ListItem Value="USA">United States</asp:ListItem>
                                                <asp:ListItem Value="UMI">United States Minor Outlying Islands</asp:ListItem>
                                                <asp:ListItem Value="URY">Uruguay</asp:ListItem>
                                                <asp:ListItem Value="UZB">Uzbekistan</asp:ListItem>
                                                <asp:ListItem Value="VUT">Vanuatu</asp:ListItem>
                                                <asp:ListItem Value="VEN">Venezuela, Bolivarian Republic of</asp:ListItem>
                                                <asp:ListItem Value="VNM">Viet Nam</asp:ListItem>
                                                <asp:ListItem Value="VGB">Virgin Islands, British</asp:ListItem>
                                                <asp:ListItem Value="VIR">Virgin Islands, U.S.</asp:ListItem>
                                                <asp:ListItem Value="WLF">Wallis and Futuna</asp:ListItem>
                                                <asp:ListItem Value="ESH">Western Sahara</asp:ListItem>
                                                <asp:ListItem Value="YEM">Yemen</asp:ListItem>
                                                <asp:ListItem Value="ZMB">Zambia</asp:ListItem>
                                                <asp:ListItem Value="ZWE">Zimbabwe</asp:ListItem>
                                            </asp:dropdownlist>
            </div>
        </div>

        <div class="row">
            <div class="form-group col-xs-12">
                <label for="bio" class="sr-only">Short Bio</label>
                <asp:textbox id="TextBox3" cssclass="form-control input-group-lg" placeholder="Your Short Bio" runat="server"></asp:textbox>
            </div>
        </div>

        <div class="row">
            <p class="birth"><strong>About Me!</strong></p>
            <div class="form-group col-xs-12">
                <label for="bio" class="sr-only">About Me</label>
                <asp:textbox id="TextBox4" cssclass="form-control input-group-lg" placeholder="About..." runat="server"></asp:textbox>
            </div>
        </div>

        <div class="row">
            <p class="birth"><strong>Profile Image</strong></p>
            <div class="form-group col-xs-12">
                <label for="Pimage" class="sr-only">Profile Image</label>

                <asp:fileupload id="FileUpload1" runat="server" />
                &nbsp;
        <asp:button id="uploadBtn" runat="server" text="Upload Image" OnClick="uploadBtn_Click" />
                <br />
                <asp:label id="lbl_error" runat="server" text="Label"></asp:label>
                <br />
                <asp:image id="Image1" runat="server" height="200px" width="200px" />

            </div>
        </div>

                <div class="row">
            <p class="birth"><strong>Cover Image</strong></p>
            <div class="form-group col-xs-12">
                <label for="Pimage" class="sr-only">Cover Image</label>

                <asp:fileupload id="FileUpload2" runat="server" />
                &nbsp;
        <asp:button id="uploadBtn2" runat="server" text="Upload Image" OnClick="uploadBtn2_Click" />
                <br />
                <asp:label id="lbl_error2" runat="server" text="Label"></asp:label>
                <br />
                <asp:image id="Image2" runat="server" height="200px" width="200px" />

            </div>
        </div>


        <!--Register Now Form Ends-->
        <asp:button id="Button1" cssclass="btn btn-primary" runat="server" text="EDIT INFO" OnClick="Button1_Click" />

    </div>


</asp:Content>
