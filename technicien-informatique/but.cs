body {
  background-color: #eef6f9;
  font-family: 'Segoe UI', sans-serif;
  text-align: center;
  padding: 40px;
  overflow: hidden;
}

h2 {
  color: #0077b6;
  font-size: 2.5em;
  margin-bottom: 30px;
}

img {
  width: 300px;
  border: 5px solid #0077b6;
  border-radius: 20px;
  animation: zoomIn 1s;
}

/* Bulles flottantes (illustration CSS) */
body::before, body::after {
  content: '';
  position: absolute;
  width: 100px;
  height: 100px;
  background: rgba(0, 119, 182, 0.2);
  border-radius: 50%;
  top: 50%;
  left: 50%;
  animation: float 6s infinite alternate;
  z-index: -1;
}

body::after {
  width: 60px;
  height: 60px;
  top: 30%;
  left: 70%;
  animation-delay: 2s;
}

@keyframes float {
  0% { transform: translate(-50%, -50%) scale(1); }
  100% { transform: translate(-40%, -60%) scale(1.2); }
}

@keyframes zoomIn {
  from { transform: scale(0.9); opacity: 0; }
  to { transform: scale(1); opacity: 1; }
}
