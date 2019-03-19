
<?php
         
         if(isset($_P0ST['submit'])){
		    if(empty($_P0ST["message"]))
			{
			  "please enter your name, email and message"
			 
			}else
			{
			 $to= "namagembedaphine@gmail.com";
			 $subject= "form-Tutorial";
			 $name_field= $_P0ST['first_name'];
			 $email_field= $_P0ST['email'];
			 $message= $_P0ST['message'];
			 $body= "from:$name_field\n E-mail:$email_field\n message:\n $message";
			 $success= mail($to, $subject, $body);
			 if($success)
			 {
			     $url= "http://www.namagembedaphine@gmail.com";
				 Header("Location:" .$url)
			 }else
			 {
			     die("message cannot be sent");
			 }
			}
		 }	 
	
	
	     ?>
