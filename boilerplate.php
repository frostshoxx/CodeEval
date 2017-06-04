<?php

$fh = fopen($argv[1], "r");
while (true) {
    $test = fgets($fh);
    # break loop if $test is an empty line
    if (empty($test))
        return;
    # $test represents the test case, do something with it
}

?>
