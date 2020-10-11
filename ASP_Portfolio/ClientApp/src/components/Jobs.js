import React, { Component } from 'react';
import axios from 'axios';

export class Jobs extends Component {

    constructor(props){
        super(props);

        this.state = {
            jobs: [],
            loading: true
        }
    }

    componentDidMount(){
        this.populateJobsData();
    }

    populateJobsData(){
        axios.get("api/jobs/GetAllJobs").then(result => {
            const response = result.data;
            this.setState({jobs: response, loading: false});
            console.log(this.state.jobs.length)
        })
    }

    renderAllJobsTable(jobs){
        return (
            <table className="table table-striped">
                <thead>
                    <tr>
                        <th>Title</th>
                        <th>Company</th>
                        <th>City</th>
                        <th>Province</th>
                        <th>Start Date</th>
                        <th>End Date</th>
                    </tr>
                </thead>
                <tbody>
                    {
                        jobs.map(job => (
                    <tr key={job.id}>
                        <td>{job.title}</td>
                        <td>{job.company}</td>
                        <td>{job.city}</td>
                        <td>{job.province}</td>
                        <td>{new Date(job.startDate).toLocaleDateString()}</td>
                        <td>{job.endDate ? new Date(job.endDate).toLocaleDateString() : `Current Job`}</td>
                    </tr>
                        ))
                    }
                </tbody>
            </table>
        )
    }
    

    render(){
        const content = this.state.loading ? (
            <p><em>Loading...</em></p>
        ) : (
            this.renderAllJobsTable(this.state.jobs)
        )
        return (
        <>
            <h1>All Jobs</h1>
            <p>Here are all jobs</p>
            {content}
        </>
        )
    }
}