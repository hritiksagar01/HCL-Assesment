document.getElementById("registrationForm").addEventListener("submit", function (e) {
  e.preventDefault();

  document.querySelectorAll(".error").forEach(el => el.textContent = "");

  let name = document.getElementById("name").value.trim();
  let email = document.getElementById("email").value.trim();
  let course = document.getElementById("course").value;
  let terms = document.getElementById("terms").checked;

  let genderInput = document.querySelector('input[name="gender"]:checked');
  let gender = genderInput ? genderInput.value : "";

  let isValid = true;

  if (name === "") {
    document.getElementById("nameError").textContent = "Name should not be empty";
    isValid = false;
  }

  if (email === "" || !email.includes("@")) {
    document.getElementById("emailError").textContent = "Email should be valid";
    isValid = false;
  }

  if (gender === "") {
    document.getElementById("genderError").textContent = "Gender must be selected";
    isValid = false;
  }

  if (course === "") {
    document.getElementById("courseError").textContent = "Course must be selected";
    isValid = false;
  }

  if (!terms) {
    document.getElementById("termsError").textContent = "Terms checkbox must be checked";
    isValid = false;
  }

  if (isValid) {
    document.getElementById("output").innerHTML = `
      <p class="success">Registration Successful!</p>
      <p>Name: ${name}</p>
      <p>Email: ${email}</p>
      <p>Gender: ${gender}</p>
      <p>Course: ${course}</p>
    `;
  }
});
