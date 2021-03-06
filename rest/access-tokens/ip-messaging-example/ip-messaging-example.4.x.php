<?php
require_once('./twilio-php/Services/Twilio.php');

// Required for all Twilio access tokens
$twilioAccountSid = 'ACxxxxxxxxxxxx';
$twilioApiKey = 'SKxxxxxxxxxxxx';
$twilioApiSecret = 'xxxxxxxxxxxxxx';

// Required for IP messaging grant
$ipmServiceSid = 'ISxxxxxxxxxxxx';
$appName = 'HipFlowSlackDockRC';
$identity = 'user@example.com';
$deviceId = 'someiosdevice';
$endpointId = $appName . ':' . $identity . ':' . $deviceId;

// Create access token
$token = new Services_Twilio_AccessToken(
    $twilioAccountSid, 
    $twilioApiKey, 
    $twilioApiSecret, 
    3600, 
    $identity
);

// Create IP Messaging grant
$ipmGrant = new Services_Twilio_Auth_IpMessagingGrant();
$ipmGrant->setServiceSid($ipmServiceSid);
$ipmGrant->setEndpointId($endpointId);

// Add grant to token
$token->addGrant($ipmGrant);

// render token to string
echo $token->toJWT();