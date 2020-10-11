import React, { Component } from 'react';

export class Home extends Component {
  static displayName = Home.name;

  render () {
    return (
    <>
        <section class="jumbotron text-center">
          <div class="container">
            <img src="me.jpg" height="300" id="profile"/>
            <br/><br/>
            <h1>Hongjo Lim</h1>
            <br/>
            <p class="lead text-muted">.NET, C#, Android, Python Developer</p>
            <p>
                <a href="mailto:hongjo1988@gmail.com" class="btn btn-primary my-2">Email Me</a>
            </p>
          </div>
        </section>
        <div class="album py-5 bg-light">
          <div class="container">
              <div class="row">
                  <div class="col-md-4">
                    <div class="card mb-4 shadow-sm">
                      <img src = "image.png" height="225"/>
                      <div class="card-body">
                      <p class="card-text"></p>
                      <p class="card-text"></p>
                      </div>
                    </div>
              </div>
          </div>
        </div>
        </div>
      </>
        
    );
  }
}
