<!DOCTYPE html>
<html>
<head>
    <title>Circle Calculator</title>
</head>
<body>
<h1>Calculate the area and perimeter of the circle </h1>

    
	<form method="POST" action="<?php echo $_SERVER['PHP_SELF']; ?>">
        <label for="radius">Enter the radius:</label>
        <input type="number" name="radius" id="radius" required>
        <input type="submit" value="Calculate">
    </form>
	
	<p> please Click on the Calculate button, and the input will be sent to a page on the server called "circle_calculate.php".</p>

    <?php
    //Check if the form is submitted
    if ($_SERVER["REQUEST_METHOD"] == "POST") 
	{
        // Retrieve the radius from the form
        $radius = $_POST["radius"];

        // Calculate the area and perimeter of the circle
        $area = pi() * $radius * $radius;
        $perimeter = 2 * pi() * $radius;

        // Display the results 
        echo "<p>Radius: $radius</p>";
        echo "<p>Area: $area</p>";
        echo "<p>Perimeter: $perimeter</p>";
		
    }
    ?>
</body>
</html>