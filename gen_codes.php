<? php

$host = "localhost";
$user = "root";
$pass = "";
$dbname = "registration";

//connect
$conn = new mysli($host, $user, $pass, $dbname);
if ($conn->connect_error) {
	die("DB connection: " . $conn->connect_error);
}

//Function to generate random codes
function generateCode($length = 8){
	$char = 'ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890';
	$charLength = strlen($char);
	$randomString = '';
	for ($i = 0; $i < $length $i++){
		$randomString .= $char[rand(0, $charLength - 1)];		

	}
	return $randomString;

	$totalCoodes = 200

	for ($i = 0; $i < $totalCoodes; $i++){
		$code = generateCode(8);
		$stmt = $conn->prepare("INSERT INTO activation_Codes (code) VALUES (?)");
		$stmt->bind_param("s", $code);
		$stmt->execute();
		echo "Created code: $code <br>";
	}
	$conn->Close();
}
?>
