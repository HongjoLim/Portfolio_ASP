import React, { Component } from 'react';
import { Nav, NavItem, NavLink } from 'reactstrap';
import { Link } from 'react-router-dom';
import './NavMenu.css';

export class NavMenu extends Component {
  static displayName = NavMenu.name;

  constructor (props) {
    super(props);

    this.toggleNavbar = this.toggleNavbar.bind(this);
    this.state = {
      collapsed: true
    };
  }

  toggleNavbar () {
    this.setState({
      collapsed: !this.state.collapsed
    });
  }

  render () {
    return (
      <>
        <div id="sidebar">
          <div className="inner">
            <nav>
              <ul>
                <li>
                  <a tag={Link} href="/">Home</a>
                </li>
                <li>
                  <a tag={Link} href="/about">About Me</a>
                </li>
                <li>
                <a tag={Link} href="/jobs">Jobs</a>
                </li>
                <li>
                <a tag={Link} href="/projects">Projects</a>
                </li>
                <li>
                  <a tag={Link} href="/createJob">Create Job</a>
                </li>
              </ul>
            </nav>
          </div>
        </div>
      </>
    );
  }
}
