# LST_Calculator_for_Aster
This program calculates land surface temperature (LST) from Aster imageries. This tool was written on March 6th, 2012 with Visual Basic .NET by Hakan OGUZ. Please cite as instructed below when you use this program.

Cite as: Hakan Oguz (2015) A Software Tool for Retrieving Land Surface Temperature from ASTER Imagery, Journal of Agricultural Sciences, 21, 471-482.

Following data are prepared for users to test the program. As instructed in the manuscript this program requires ASTER bands as input in order to calculate land surface temperature.

Test data were located in "input files" folder and include:

ASTER band_2 (data type is Byte)
ASTER band_3 (data type is Byte)
ASTER TIR band (band 14) (data type is Short)


Parameter values that are going to be used during test run of LST Calculator with the test data are as follows: 


PARAMETER NAME						VALUE
UCC (Unit Conversion Coefficient) for Band 2		0.708
UCC (Unit Conversion Coefficient) for Band 3N		0.862
UCC (Unit Conversion Coefficient) for Band 14		0.0052
Julian Day (the day of the year)			236
Mean Solar Exoatmospheric Irradiances for Band 2	1555.74
Mean Solar Exoatmospheric Irradiances for Band 3N	1119.47
Solar Elevation Angle (in degrees)			57.90
Dark Object Value for Band 2				20
Dark Object Value for Band 3N				17
K1 for Band 14						649.60
K2 for Band 14						1274.49
Atmospheric Transmission				0.87
Upwelling Radiance					1.01
Downwelling Radiance					1.69


